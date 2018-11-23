using System;
using GinPlatform.NET_SDK.Routes;
using System.Collections.Generic;
using System.Threading.Tasks;
using GinPlatform.NET_SDK.Clients.Interfaces;
using GinPlatform.NET_SDK.Models.Node;

namespace GinPlatform.NET_SDK.Clients
{
    public class NodeClient : BaseAuthorizedClient, INodeClient
    {
        public Task<IEnumerable<Node>> GetAll(string apiKey = null)
        {
            return GetApiDataAuthorized<IEnumerable<Node>>(NodeRoutes.GetNodesList(), apiKey);
        }

        public Task<Node> GetDetails(string nodeId, string apiKey = null)
        {
            return GetApiDataAuthorized<Node>(NodeRoutes.GetNodeDetails(nodeId), apiKey);
        }

        public Task<Node> Create(NewNode newNode, string apiKey = null)
        {
            return GetApiDataAuthorized<Node>(NodeRoutes.GetCreateNode(), newNode, apiKey);
        }

        public async Task<bool> Delete(string nodeId, string apiKey = null)
        {
            return String.IsNullOrEmpty(await GetApiDataAuthorized<string>(NodeRoutes.GetDeleteNode(nodeId), apiKey));
        }

        public async Task<bool> Upgrade(string nodeId, string apiKey = null)
        {
            return String.IsNullOrEmpty(await GetApiDataAuthorized<string>(NodeRoutes.GetUpgradeNode(nodeId), apiKey));
        }
        
        public async Task<bool> Downgrade(string nodeId, string apiKey = null)
        {
            return String.IsNullOrEmpty(await GetApiDataAuthorized<string>(NodeRoutes.GetUpgradeNode(nodeId), apiKey));
        }
    }
}