using GinPlatform.NET_SDK.Model.Node;
using GinPlatform.NET_SDK.Routes;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace GinPlatform.NET_SDK.Clients
{
    public class NodeClient : BaseClient
    {
        public Task<IEnumerable<Node>> GetAllNodes(string apiKey = null)
        {
            return GetApiDataAuthorized<IEnumerable<Node>>(NodeRoutes.GetNodesList(), apiKey);
        }

        public Task<Node> GetNodeDetails(string nodeId, string apiKey = null)
        {
            return GetApiDataAuthorized<Node>(NodeRoutes.GetNodeDetails(nodeId), apiKey);
        }

        public Task<Node> CreateNode(NewNode newNode, string apiKey = null)
        {
            return GetApiDataAuthorized<Node>(NodeRoutes.GetCreateNode(), newNode, apiKey);
        }
    }
}