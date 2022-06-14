using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using WooCommerceDomain.Models.DbModels;
using WooCommerceDomain.Models.RawModels;

namespace WooCommerceWorkerService.Mapper
{
    public class CustomMapper
    {
        public List<DbOrderModel> MapRawOrderToDbOrder(RawOrderModel rawOrderModel)
        {
            var productName = GetProductName(rawOrderModel);
            var total = GetTotal(rawOrderModel);
            var metaDataItemlist = GetMetaDataItemList(rawOrderModel);
            List<DbOrderModel> dbOrderModelList = new List<DbOrderModel>();
   
            foreach (var metaDatalist in metaDataItemlist)
            {
                foreach (var item in metaDatalist)
                {
                    for (int i = 0; i < item.Key; i++)
                    {
                        var metaDataDaysCount = item.Value.Where(m => m.Key.Equals("Ilość dni"));
                        var daysCount = GetDaysNumber(GetDaysCount(metaDataDaysCount));

                        var startDay = GetStartDay(item.Value);
                        var endDay = GetEndDate(startDay, daysCount);
                        var birthday = GetBirthday(rawOrderModel.MainMetaDataModels);

                        string metaDataDietDescription = GetMetaDataDietDescription(item.Value);

                        AddressModel addressModel = new AddressModel
                        {
                            Street = rawOrderModel.BillingModels.Street,
                            City = rawOrderModel.BillingModels.City,
                            PostCode = rawOrderModel.BillingModels.PostCode
                        };

                        ClientModel clientModel = new ClientModel
                        {
                            FirstName = rawOrderModel.BillingModels.FirstName,
                            LastName = rawOrderModel.BillingModels.LastName,
                            Email = rawOrderModel.BillingModels.Email,
                            Phone = rawOrderModel.BillingModels.Phone,
                            Birthday = birthday,
                            Address = addressModel
                        };

                        DbOrderModel dbOrderModel = new DbOrderModel
                        {
                            OrderId = rawOrderModel.OrderId,
                            Status = rawOrderModel.Status,
                            DateCreated = rawOrderModel.DateCreated,
                            ProductName = productName,
                            Total = total,
                            DaysCount = daysCount,
                            DateStart = DateTime.ParseExact(startDay, "yyyy-MM-dd", CultureInfo.InvariantCulture),
                            DateEnd = DateTime.ParseExact(endDay, "yyyy-MM-dd", CultureInfo.InvariantCulture),
                            DietDescription = metaDataDietDescription,
                            Client = clientModel
                        };

                        dbOrderModelList.Add(dbOrderModel);
                    }
                }
            }
            return dbOrderModelList;
        }
        

        private DateTime? GetBirthday(List<MainMetaDataModel> mainMetaDataModels)
        {
            try
            {
                if (mainMetaDataModels.Where(d => d.Key.Equals("data_urodzenia")).ToList().Count < 1)
                {
                    return null;
                }
                var result = mainMetaDataModels.Where(d => d.Key.Equals("data_urodzenia")).Select(d => d.Value).FirstOrDefault();
                return Convert.ToDateTime(result);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DbProductModel MapRawProductToDbProduct(RawProductModel rawProductModel)
        {
            return new DbProductModel
            {
                Id = rawProductModel.Id,
                Name = rawProductModel.Name
            };
        }

        private string GetStartDay(List<MetaDataModel> metaDataModels)
        {
            try
            {
                var result = metaDataModels.Where(m => m.Key.Equals("Data rozpoczęcia")).FirstOrDefault().Value;
                var dd = result.Substring(0, 2);
                var mm = result.Substring(3, 2);
                var yyyy = result.Substring(6, 4);
                DateTime.ParseExact(string.Concat(yyyy,"-",mm, "-", dd), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                return string.Concat(yyyy, "-", mm, "-", dd);
            }
            catch (Exception)
            {
                return "2000-01-01";
                //throw;
            }
        }

        private string GetDaysCount(IEnumerable<MetaDataModel> metaDataModels)
        {
            try
            {
                return metaDataModels.FirstOrDefault().Value;
            }
            catch (Exception)
            {
                return "0";
                //throw;
            }
        }

        private List<Dictionary<int, List<MetaDataModel>>> GetMetaDataItemList(RawOrderModel rawOrderModel)
        {
            try
            {
                List<Dictionary<int, List<MetaDataModel>>> keyValuePairs = new List<Dictionary<int, List<MetaDataModel>>>();
                var result = rawOrderModel.LineItemModels.Where(l => !l.ProductName.Equals("Kaucja za pojemniki")).Select(l => new { l.Quantity, l.MetaDataModels }).ToList();
                foreach (var item in result)
                {
                    Dictionary<int, List<MetaDataModel>> dict = new Dictionary<int, List<MetaDataModel>>();
                    dict.Add(item.Quantity, item.MetaDataModels);
                    keyValuePairs.Add(dict);
                }
                return keyValuePairs;
            }
            catch (Exception)
            {
                return new List<Dictionary<int, List<MetaDataModel>>>();
                //throw;
            }
        }

        private string GetTotal(RawOrderModel rawOrderModel)
        {
            try
            {
                return rawOrderModel.LineItemModels.Where(l => l.ProductName != "Kaucja za pojemniki").FirstOrDefault().Total;
            }
            catch (Exception)
            {
                return string.Empty;
                //throw;
            }
        }

        private string GetProductName(RawOrderModel rawOrderModel)
        {
            try
            {
                return rawOrderModel.LineItemModels.Where(l => !l.ProductName.Equals("Kaucja za pojemniki")).FirstOrDefault().ProductName;
            }
            catch (Exception)
            {
                return string.Empty;
                //throw;
            }
        }

        private string GetMetaDataDietDescription(List<MetaDataModel> metaDatalist)
        {
            try
            {
                var result =  metaDatalist.Where(m => !m.Key.Equals("Ilość dni") && !m.Key.Equals("Data rozpoczęcia") && !m.Key.Equals("Miasto")).FirstOrDefault().Value;
                var indexOfLastCorrectChar = result.LastIndexOf('(');
                if(indexOfLastCorrectChar > 0)
                {
                    result = result.Substring(0, indexOfLastCorrectChar);
                }
                return result;
            }
            catch (Exception)
            {
                return "";
            }
        }


        private int GetDaysNumber(string inputText)
        {
            Regex regex = new Regex("^[0-9]");
            Char[] vs = inputText.ToArray();

            for (int i = 0; i < vs.Length; i++)
            {
                var strToCheck = vs[i].ToString();
                Match m = regex.Match(strToCheck);
                if(!m.Success)
                {
                    return Convert.ToInt32(inputText.Substring(0, i));
                }
            }
            return Convert.ToInt32(inputText);
        }

        private string GetEndDate(string startDate, int numofDays)
        {
            try
            {
                DateTime dateTime = DateTime.ParseExact(startDate, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                for (int i = 1; i < numofDays; i++)
                {
                    dateTime = dateTime.AddDays(1);
                    if (dateTime.DayOfWeek == DayOfWeek.Saturday)
                    {
                        dateTime = dateTime.AddDays(2);
                    }
                    else if (dateTime.DayOfWeek == DayOfWeek.Sunday)
                    {
                        dateTime = dateTime.AddDays(1);
                    }
                }
                return dateTime.ToString("yyyy-MM-dd");
            }
            catch (Exception)
            {
                return "2000-01-01"; ;
            }     
        }
    }
}
