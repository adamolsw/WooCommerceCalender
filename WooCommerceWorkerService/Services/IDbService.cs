using System;
using System.Collections.Generic;
using WooCommerceDomain.Models;
using WooCommerceDomain.Models.DbModels;

namespace WooCommerceWorkerService.Services
{
    public interface IDbService
    {
        void AddOrder(DbOrderModel dbOrderModel);
        List<DbProductModel> GetProducts();
        string GetCreateDateOfLastOrder();
        List<DbOrderModel> GetOrdersForSingleDayByDay(string date);
        List<DayDetailsModel> GetOrdersDetailsForSingleDayByDay(string date);
        void AddExcludedDay(int orderId, DateTime date);
        void AddProducts(List<DbProductModel> product);
        int GetMaxOrderid();
    }
}