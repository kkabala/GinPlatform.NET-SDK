using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GinPlatform.NET_SDK.Models.Node
{
    public class NodeUpdate
    {
        public NodeUpdate(string id, string name, Dictionary<string, string> meta)
        {
            Id = id;
            Name = name;
            Meta = meta;
        }

        [JsonIgnore]
		public string Id { get; }

        [JsonProperty("name")]
		public string Name { get; }

        [JsonProperty("meta")]
		public Dictionary<string, string> Meta { get; }
    }
}
