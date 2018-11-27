using Newtonsoft.Json;

namespace GinPlatform.NET_SDK.Models.Blockchain
{
    public class Exchange
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}