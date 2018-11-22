using System;
using System.Collections.Generic;

namespace GinPlatform.NET_SDK.Model.Node
{
    public class Node
    {
        public string Id { get; set; }
        public string Blockchain { get; set; }
        public int Collateral { get; set; }
        public bool Dedicated { get; set; }
        public Ip Ip { get; set; }
        public string Pk { get; set; }
        public Tx Tx { get; set; }
        public string Status { get; set; }
        public string Masternode_Status { get; set; }
        public string Address { get; set; }
        public bool Port_Status { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Expires_at { get; set; }
        public DateTime Updated_at { get; set; }
        public DateTime Updated_MnStatus_at { get; set; }
        public object Updated_Internal_status_at { get; set; }
        public DateTime Updated_PortStatus_at { get; set; }
        public DateTime Updated_Financials_at { get; set; }
        public Dictionary<string,string> Meta { get; set; }
    }
}
