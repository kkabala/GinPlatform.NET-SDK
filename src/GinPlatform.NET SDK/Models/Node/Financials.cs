using System;
using Newtonsoft.Json;

namespace GinPlatform.NET_SDK.Models.Node
{
    public class Financials
    {
        [JsonProperty("last_reward_at")]
        public DateTime LastRewardAt { get; set; }

        [JsonProperty("rewards")]
        public int Rewards { get; set; }

        [JsonProperty("rewards_today")]
        public int RewardsToday { get; set; }

        [JsonProperty("rewards_month")]
        public int RewardsMonth { get; set; }

        [JsonProperty("exits")]
        public double Exits { get; set; }

        [JsonProperty("exits_btc_val")]
        public double ExitsBtcVal { get; set; }
    }
}