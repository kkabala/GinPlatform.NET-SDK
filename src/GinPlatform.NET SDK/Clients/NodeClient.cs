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

        public Task<Node> Create(NodeCreationData nodeCreationData, string apiKey = null)
        {
            return GetApiDataAuthorized<Node>(NodeRoutes.GetCreateNode(), nodeCreationData, apiKey);
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

        public async Task<bool> Rebuild(string nodeId, string apiKey = null)
        {
            return String.IsNullOrEmpty(await GetApiDataAuthorized<string>(NodeRoutes.GetRebuildNode(nodeId), apiKey));
        }

        public Task<RewardsList> GetRewards(string nodeId, int pageNumber = 1, string apiKey = null)
        {
            return GetApiDataAuthorized<RewardsList>(NodeRoutes.GetNodeRewards(nodeId, pageNumber), apiKey);
        }
    }
}