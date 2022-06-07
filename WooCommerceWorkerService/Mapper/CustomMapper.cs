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
        public DbOrderModel MapRawOrderToDbOrder(RawOrderModel rawOrderModel)
        {
            var productName = GetProductName(rawOrderModel);
            var total = GetTotal(rawOrderModel);
            var metaDatalist = GetMetaDataList(rawOrderModel);

            var metaDataDaysCount = metaDatalist.Where(m => m.Key.Equals("Ilość dni"));
            var daysCount = GetDaysNumber(GetDaysCount(metaDataDaysCount));

            var startDay = GetStartDay(metaDatalist);
            var endDay = GetEndDate(startDay, daysCount);

            string metaDataDietDescription = GetMetaDataDietDescription(metaDatalist);

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
                Address = addressModel
            };

            return new DbOrderModel
            {
                Id = rawOrderModel.Id,
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

        private List<MetaDataModel> GetMetaDataList(RawOrderModel rawOrderModel)
        {
            try
            {
                return rawOrderModel.LineItemModels.Where(l => !l.ProductName.Equals("Kaucja za pojemniki")).FirstOrDefault().MetaDataModels;
            }
            catch (Exception)
            {
                return new List<MetaDataModel>();
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
                return metaDatalist.Where(m => !m.Key.Equals("Ilość dni") && !m.Key.Equals("Data rozpoczęcia") && !m.Key.Equals("Miasto")).FirstOrDefault().Value;
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
