using System.Collections.Generic;

namespace GinPlatform.NET_SDK.Model.Node
{
    public class NewNode
    {
        public NewNode(int dedicated, string blockchain, int collateral, string txid, Dictionary<string, string> meta)
        {
            Dedicated = dedicated;
            Blockchain = blockchain;
            Collateral = collateral;
            Txid = txid;
            Meta = meta;
        }
        public int Dedicated { get; }
        public string Blockchain { get; }
        public int    Collateral { get; }
        public string Txid { get; }
        Dictionary<string, string> Meta { get;}
    }
}