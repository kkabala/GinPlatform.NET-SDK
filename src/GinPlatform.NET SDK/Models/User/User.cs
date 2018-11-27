using System;
using Newtonsoft.Json;

namespace GinPlatform.NET_SDK.Models.User
{
    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("fullname")]
        public string Fullname { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("balance")]
        public double Balance { get; set; }

        [JsonProperty("currency_balance")]
        public double CurrencyBalance { get; set; }

        [JsonProperty("balance_address")]
        public string BalanceAddress { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("civic")]
        public bool Civic { get; set; }

        [JsonProperty("can_vote_tiers")]
        public bool CanVoteTiers { get; set; }

        [JsonProperty("notification_masternode_status")]
        public bool NotificationMasternodeStatus { get; set; }

        [JsonProperty("api")]
        public bool Api { get; set; }

        [JsonProperty("api_key")]
        public string ApiKey { get; set; }

        [JsonProperty("terms")]
        public bool Terms { get; set; }

        [JsonProperty("privacy")]
        public bool Privacy { get; set; }
    }
}
