using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WooCommerceDomain.Models.RawModels
{
    public class RawOrderModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("date_created")]
        public string DateCreated { get; set; }
        [JsonProperty("billing")]
        public BillingModel BillingModels { get; set; }
        [JsonProperty("line_items")]
        public List<LineItemModel> LineItemModels { get; set; }
    }
}
