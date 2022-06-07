using System.Collections.Generic;
using WooCommerceDomain.Models;
using WooCommerceDomain.Models.DbModels;

namespace WooCommerceWorkerService.Services
{
    public interface IDbService
    {
        void AddOrder(DbOrderModel dbOrderModel);
        void GetAddresses();
        string GetCreateDateOfLastOrder();
        List<DbOrderModel> GetOrdersForSingleDayByDay(string date);
        List<DayDetailsModel> GetOrdersDetailsForSingleDayByDay(string date);
    }
}