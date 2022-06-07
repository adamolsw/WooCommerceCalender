using System.Collections.Generic;
using WooCommerceDomain.Models.DbModels;

namespace WooCommerceWorkerService.Services
{
    public interface IWooCommerceService
    {
        object AddOrder { get; }

        void GetAllProductsAsync();
        List<DbOrderModel> GetOrders(string newerThan, int page = 1);
    }
}