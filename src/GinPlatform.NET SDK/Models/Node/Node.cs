using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace GinPlatform.NET_SDK.Models.Node
{
    public class Node
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("blockchain")]
        public string Blockchain { get; set; }

        [JsonProperty("collateral")]
        public int Collateral { get; set; }

        [JsonProperty("dedicated")]
        public bool Dedicated { get; set; }

        [JsonProperty("ip")]
        public Ip Ip { get; set; }

        [JsonProperty("pk")]
        public string Pk { get; set; }

        [JsonProperty("tx")]
        public Tx Tx { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("masternode_status")]
        public string MasternodeStatus { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("port_status")]
        public bool? PortStatus { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("expires_at")]
        public DateTime ExpiresAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("updated_mnstatus_at")]
        public DateTime? UpdatedMnStatusAt { get; set; }

        [JsonProperty("updated_internal_status_at")]
        public object UpdatedInternalStatusAt { get; set; }

        [JsonProperty("updated_portstatus_at")]
        public DateTime? UpdatedPortStatusAt { get; set; }

        [JsonProperty("updated_financials_at")]
        public DateTime? UpdatedFinancialsAt { get; set; }

        [JsonProperty("last_started_at")]
        public DateTime? LastStartedAt { get; set; }

        [JsonProperty("financials")]
        public Financials Financials { get; set; }

        [JsonProperty("meta")]
        public Dictionary<string,string> Meta { get; set; }
    }
}