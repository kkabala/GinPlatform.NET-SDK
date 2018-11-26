using System.Collections.Generic;

namespace GinPlatform.NET_SDK.Models.Node
{
	public class NewNode
	{
		public NewNode(int dedicated, string blockchain, int collateral, string txid, Dictionary<string, string> meta = null)
		{
			Dedicated = dedicated;
			Blockchain = blockchain;
			Collateral = collateral;
			Txid = txid;
			Meta = meta ?? new Dictionary<string, string>();
		}
		public int Dedicated { get; }
		public string Blockchain { get; }
		public int Collateral { get; }
		public string Txid { get; }
		public Dictionary<string, string> Meta { get; }
	}
}