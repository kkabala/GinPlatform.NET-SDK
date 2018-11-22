using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GinPlatform.NET_SDK.Model.Node;
using GinPlatform.NET_SDK.Routes;
using Newtonsoft.Json;

namespace GinPlatform.NET_SDK.Clients
{
    public class NodeClient : BaseClient
    {
        public async Task<IEnumerable<Node>> GetAllNodes(string apiKey = null)
        {
            SetAuthorizationHeader(apiKey);
            var nodesResponse = await httpClient.SendAsync(NodeRoutes.GetNodesList());
            nodesResponse.EnsureSuccessStatusCode();
            var nodesJson = await nodesResponse.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Node>>(nodesJson);
        }

        public async Task<Node> GetNodeDetails(string nodeId, string apiKey = null)
        {
            SetAuthorizationHeader(apiKey);
            var nodeResponse = await httpClient.SendAsync(NodeRoutes.GetNodeDetails(nodeId));
            nodeResponse.EnsureSuccessStatusCode();
            var nodeJson = await nodeResponse.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Node>(nodeJson);
        }

        public async Task<Node> CreateNode(NewNode newNode, string apiKey = null)
        {
            SetAuthorizationHeader(apiKey);
            var requestMessage = NodeRoutes.GetCreateNode();
            requestMessage.Content = new StringContent(JsonConvert.SerializeObject(newNode));
            var nodeResponse = await httpClient.SendAsync(requestMessage);
            nodeResponse.EnsureSuccessStatusCode();
            var nodeJson = await nodeResponse.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Node>(nodeJson);
        }
    }
}