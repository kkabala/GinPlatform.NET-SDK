using System;
using Newtonsoft.Json;

namespace GinPlatform.NET_SDK.Models.User
{
    public class Transaction
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }
    }
}