﻿using System;
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
            var productName = rawOrderModel.LineItemModels.Where(l => !l.ProductName.Equals("Kaucja za pojemniki")).FirstOrDefault().ProductName;
            var total = rawOrderModel.LineItemModels.Where(l => l.ProductName != "Kaucja za pojemniki").FirstOrDefault().Total;
            var metaDatalist = rawOrderModel.LineItemModels.Where(l => !l.ProductName.Equals("Kaucja za pojemniki")).FirstOrDefault().MetaDataModels;

            var metaDataDaysCount = metaDatalist.Where(m => m.Key.Equals("Ilość dni"));
            var daysCount = GetDaysNumber(metaDataDaysCount.FirstOrDefault().Value);

            var startDay = metaDatalist.Where(m => m.Key.Equals("Data rozpoczęcia")).FirstOrDefault().Value;
            var endDay = GetEndDate(startDay, daysCount);

            var metaDataDietDescription = metaDatalist.Where(m => !m.Key.Equals("Ilość dni") && !m.Key.Equals("Data rozpoczęcia") && !m.Key.Equals("Miasto")).FirstOrDefault().Value;

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
                DateStart = startDay,
                DateEnd = endDay,
                DietDescription = metaDataDietDescription,
                Client = clientModel
            };
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
            DateTime dateTime = DateTime.ParseExact(startDate, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);

            for (int i = 1; i < numofDays; i++)
            {
                dateTime = dateTime.AddDays(1);
                if(dateTime.DayOfWeek == DayOfWeek.Saturday)
                {
                    dateTime = dateTime.AddDays(2);
                }
                else if (dateTime.DayOfWeek == DayOfWeek.Sunday)
                {
                    dateTime = dateTime.AddDays(1);
                }
            }
            return dateTime.ToString("dd.MM.yyyy");
        }
    }
}