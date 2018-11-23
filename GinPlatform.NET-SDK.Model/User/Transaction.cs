using System;
using System.Collections.Generic;
using System.Text;

namespace GinPlatform.NET_SDK.Model.User
{
    public class Transaction
    {
        public string Description { get; set; }
        public double Amount { get; set; }
        public DateTime Created_At { get; set; }
        public double Balance { get; set; }
    }
}
