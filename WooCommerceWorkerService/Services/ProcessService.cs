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
            await ProcessOrders();
        }

        private async Task ProcessOrders()
        {
            var products = _wooCommerceService.GetAllProductsAsync();
            if(products.Count > 0)
            {
                _dbService.AddProducts(products);
            }            

            while (true)
            {
                var createDateOfLastOrder = _dbService.GetCreateDateOfLastOrder();
                var orders = _wooCommerceService.GetOrders(createDateOfLastOrder);
                if(orders.Count <= 0)
                {
                    break;
                }


                foreach (var order in orders)
                {
                    _dbService.AddOrder(order);
                }
            }
        }
    }
}
