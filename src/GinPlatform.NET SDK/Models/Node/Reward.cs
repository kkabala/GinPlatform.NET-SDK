using Newtonsoft.Json;
using System;

namespace GinPlatform.NET_SDK.Models.Node
{
    public class Reward
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("amount_btc")]
        public double AmountBtc { get; set; }

        [JsonProperty("txid")]
        public string Txid { get; set; }
        
        [JsonProperty("block_hash")]
        public string BlockHash { get; set; }
    }
}