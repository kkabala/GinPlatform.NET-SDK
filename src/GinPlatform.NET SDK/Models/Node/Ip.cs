using Newtonsoft.Json;

namespace GinPlatform.NET_SDK.Models.Node
{
    public class Ip
    {
        [JsonProperty("v4")]
        public string V4 { get; set; }

        [JsonProperty("v6")]
        public object V6 { get; set; }

        [JsonProperty("default")]
        public string Default { get; set; }
    }
}