using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WooCommerceWorkerService.Services
{
    public class ProcessService : IProcessService
    {
        private IDbService _dbService;
        private IWooCommerceService _wooCommerceService;

        public ProcessService(IDbService dbService, IWooCommerceService wooCommerceService)
        {
            _dbService = dbService;
            _wooCommerceService = wooCommerceService;
        }

        public async Task RunAsync()
        {
            ////wooCommerceService.GetAllProductsAsync();
            //var orders = _wooCommerceService.GetOrders();


            await ProcessOrders();
        }

        private async Task ProcessOrders()
        {
            while(true)
            {
                var createDateOfLastOrder = _dbService.GetCreateDateOfLastOrder();
                var orders = _wooCommerceService.GetOrders(createDateOfLastOrder);
                if(orders.Count <= 0)
                {
                    break;
                }


                foreach (var item in orders)
                {
                    _dbService.AddOrder(item);
                }
            }
        }
    }
}
