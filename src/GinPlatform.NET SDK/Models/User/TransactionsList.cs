using System.Collections.Generic;

namespace GinPlatform.NET_SDK.Models.User
{
    public class TransactionsList
    {
        public int Total { get; set; }
        public List<Transaction> List { get; set; }
    }
}
