using Newtonsoft.Json;
using System.Collections.Generic;

namespace WooCommerceDomain.Models.RawModels
{
    public class LineItemModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string ProductName { get; set; }
        [JsonProperty("total")]
        public string Total { get; set; }
        [JsonProperty("meta_data")]
        public List<MetaDataModel> MetaDataModels { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
    }
}
