using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WooCommerceDomain.Models;
using WooCommerceDomain.Models.DbModels;
using WooCommerceDomain.Models.RawModels;
using WooCommerceWorkerService.Mapper;

namespace WooCommerceWorkerService.Services
{
    public class WooCommerceService
    {
        private const string URL = "https://hashtagdietcatering.pl/wp-json/wc/v3/orders";
        private string urlParameters = "?consumer_secret=cs_4a6d797f575a3b795255f7e5a8c6b0c61c87b372&consumer_key=ck_9b6d85e5d46e4eb8c3df394c110fa829be8b9600&fbclid";

        public void GetAllProductsAsync()
        {
            CustomMapper customMapper = new CustomMapper();
            List<DbOrderModel> dbOrderModels = new List<DbOrderModel>();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(urlParameters).Result; 
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                var dataObjects = response.Content.ReadAsStringAsync().Result.Replace("&", "").Replace("#", "").Replace(";", "");
                var result = JsonConvert.DeserializeObject<IEnumerable<RawOrderModel>>(dataObjects);

                foreach (var item in result)
                {
                    dbOrderModels.Add(customMapper.MapRawOrderToDbOrder(item));
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }
    }
}
