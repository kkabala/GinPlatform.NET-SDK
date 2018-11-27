using Newtonsoft.Json;

namespace GinPlatform.NET_SDK.Models.Node
{
    public class Tx
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }
    }
}