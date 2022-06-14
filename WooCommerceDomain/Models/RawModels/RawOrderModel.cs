using Newtonsoft.Json;
using System.Collections.Generic;

namespace WooCommerceDomain.Models.RawModels
{
    public class RawOrderModel
    {
        [JsonProperty("id")]
        public int OrderId { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("date_created")]
        public string DateCreated { get; set; }
        [JsonProperty("billing")]
        public BillingModel BillingModels { get; set; }
        [JsonProperty("line_items")]
        public List<LineItemModel> LineItemModels { get; set; }
        [JsonProperty("meta_data")]
        public List<MainMetaDataModel> MainMetaDataModels { get; set; }
    }
}
