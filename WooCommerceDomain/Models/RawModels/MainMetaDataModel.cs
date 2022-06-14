using Newtonsoft.Json;

namespace WooCommerceDomain.Models.RawModels
{
    public class MainMetaDataModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("key")]
        public string  Key { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
