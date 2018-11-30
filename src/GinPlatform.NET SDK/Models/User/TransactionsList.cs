using System.Collections.Generic;
using Newtonsoft.Json;

namespace GinPlatform.NET_SDK.Models.User
{
    public class TransactionsList
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("list")]
        public List<Transaction> Transactions { get; set; }
    }
}