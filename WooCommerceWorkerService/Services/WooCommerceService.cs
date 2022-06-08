using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using WooCommerceDomain.Models.DbModels;
using WooCommerceDomain.Models.RawModels;
using WooCommerceWorkerService.Mapper;

namespace WooCommerceWorkerService.Services
{
    public class WooCommerceService : IWooCommerceService
    {
        private const string URL = "https://hashtagdietcatering.pl/wp-json/wc/v3/";
        private string urlParameters = "?consumer_secret=cs_4a6d797f575a3b795255f7e5a8c6b0c61c87b372&consumer_key=ck_9b6d85e5d46e4eb8c3df394c110fa829be8b9600&fbclid";
        private ILogger<WooCommerceService> _logger;

        public object AddOrder { get; private set; }

        public WooCommerceService(ILogger<WooCommerceService> logger)
        {
            _logger = logger;
        }

        public List<DbProductModel> GetAllProductsAsync()
        {
            _logger.LogInformation("Start - Get all products from API");

            var urlEndpoint = "products";
            CustomMapper customMapper = new CustomMapper();
            List<DbProductModel> dbOrderModels = new List<DbProductModel>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(string.Concat(URL, urlEndpoint));

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;
            if (response.IsSuccessStatusCode)
            {
                var dataObjects = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<IEnumerable<RawProductModel>>(dataObjects);

                foreach (var item in result)
                {
                    _logger.LogInformation($"The product with Id {item.Id} has been downloaded");
                    dbOrderModels.Add(customMapper.MapRawProductToDbProduct(item));
                }
            }
            else
            {
                _logger.LogError("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            _logger.LogInformation("End - Get all products from API");
            return dbOrderModels;
        }

        public List<DbOrderModel> GetOrders(string newerThan, int page = 1)
        {
            _logger.LogInformation("Start - Get all orders from API");
            if (newerThan == null)
            {
                newerThan = "2000-01-01T00:00:00";
            }
            var urlEndpoint = "orders";
            urlParameters = string.Concat(urlParameters, "&order=asc&after=", newerThan);
            CustomMapper customMapper = new CustomMapper();
            List<DbOrderModel> dbOrderModels = new List<DbOrderModel>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(string.Concat(URL, urlEndpoint));

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;
            if (response.IsSuccessStatusCode)
            {
                var dataObjects = response.Content.ReadAsStringAsync().Result.Replace("&", "").Replace("#", "").Replace(";", "");
                var result = JsonConvert.DeserializeObject<IEnumerable<RawOrderModel>>(dataObjects);

                foreach (var item in result)
                {
                    _logger.LogInformation($"The Order with Id {item.Id} has been downloaded");
                    dbOrderModels.Add(customMapper.MapRawOrderToDbOrder(item));
                }
            }
            else
            {
                _logger.LogError("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
            _logger.LogInformation("End - Get all orders from API");
            return dbOrderModels;
        }
    }
}
