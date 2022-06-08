using Newtonsoft.Json;

namespace WooCommerceDomain.Models.RawModels
{
    public class RawProductModel
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
