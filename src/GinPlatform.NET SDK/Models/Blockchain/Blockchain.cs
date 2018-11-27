using System.Collections.Generic;
using Newtonsoft.Json;

namespace GinPlatform.NET_SDK.Models.Blockchain
{
    public class Blockchain
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("ticker")]
        public string Ticker { get; set; }

        [JsonProperty("collaterals")]
        public List<int> Collaterals { get; set; }

        [JsonProperty("img")]
        public string Img { get; set; }

        [JsonProperty("imgLarge")]
        public string ImgLarge { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("explorer")]
        public string Explorer { get; set; }

        [JsonProperty("exchanges")]
        public List<Exchange> Exchanges { get; set; }

        [JsonProperty("github")]
        public string Github { get; set; }

        [JsonProperty("discord")]
        public string Discord { get; set; }

        [JsonProperty("telegram")]
        public string Telegram { get; set; }

        [JsonProperty("twitter")]
        public string Twitter { get; set; }

        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("roi")]
        public double Roi { get; set; }

        [JsonProperty("masternodes")]
        public int Masternodes { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }
    }
}