using System;
using System.Collections.Generic;
using System.Text;

namespace GinPlatform.NET_SDK.Model.User
{
    public class TransactionsList
    {
        public int Total { get; set; }
        public List<Transaction> List { get; set; }
    }
}
