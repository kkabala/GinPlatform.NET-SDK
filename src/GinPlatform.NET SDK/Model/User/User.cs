using System;

namespace GinPlatform.NET_SDK.Model.User
{
    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Fullname { get; set; }
        public string Country { get; set; }
        public double Balance { get; set; }
        public double Currency_Balance { get; set; }
        public string Balance_Address { get; set; }
        public DateTime Created_At { get; set; }
        public string Hash { get; set; }
        public string Currency { get; set; }
        public bool Civic { get; set; }
        public bool Can_Vote_Tiers { get; set; }
        public bool Notification_Masternode_Status { get; set; }
        public bool Api { get; set; }
        public string Api_Key { get; set; }
        public bool Terms { get; set; }
        public bool Privacy { get; set; }
    }
}
