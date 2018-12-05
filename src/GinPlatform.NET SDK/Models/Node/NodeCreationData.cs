using System.Collections.Generic;
using Newtonsoft.Json;

namespace GinPlatform.NET_SDK.Models.Node
{
	public class NodeCreationData
	{
		public NodeCreationData(bool dedicated, string blockchain, int collateral, string txid, Dictionary<string, string> meta = null)
		{
			Dedicated = dedicated;
			Blockchain = blockchain;
			Collateral = collateral;
			Txid = txid;
			Meta = meta ?? new Dictionary<string, string>();
		}

        [JsonProperty("dedicated")]
		public bool Dedicated { get; }

        [JsonProperty("blockchain")]
		public string Blockchain { get; }

        [JsonProperty("collateral")]
		public int Collateral { get; }

        [JsonProperty("txid")]
		public string Txid { get; }

        [JsonProperty("meta")]
		public Dictionary<string, string> Meta { get; }
	}
}