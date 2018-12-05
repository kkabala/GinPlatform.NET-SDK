using System.Collections.Generic;
using Newtonsoft.Json;

namespace GinPlatform.NET_SDK.Models.Node
{
    public class RewardsList
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("list")]
        public List<Reward> Rewards { get; set; }
    }
}