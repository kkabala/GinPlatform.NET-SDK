using System;
using Newtonsoft.Json;

namespace GinPlatform.NET_SDK.Models.Node
{
    public class Financials
    {
        [JsonProperty("last_reward_at")]
        public DateTime? LastRewardAt { get; set; }

        [JsonProperty("rewards")]
        public double Rewards { get; set; }

        [JsonProperty("rewards_today")]
        public double RewardsToday { get; set; }

        [JsonProperty("rewards_month")]
        public double RewardsMonth { get; set; }

        [JsonProperty("exits")]
        public double Exits { get; set; }

        [JsonProperty("exits_btc_val")]
        public double ExitsBtcVal { get; set; }
    }
}