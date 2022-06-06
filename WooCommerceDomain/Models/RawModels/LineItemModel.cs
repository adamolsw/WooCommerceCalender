using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
