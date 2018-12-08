using System;
using GinPlatform.NET_SDK.Routes;
using System.Collections.Generic;
using System.Threading.Tasks;
using GinPlatform.NET_SDK.Facades.Interfaces;
using GinPlatform.NET_SDK.Models.Node;

namespace GinPlatform.NET_SDK.Facades
{
    internal class NodeFacade : BaseAuthorizedFacade, INodeFacade
    {
        internal NodeFacade(string apiKey) : base(apiKey)
        {
        }

        public Task<IEnumerable<Node>> GetAll()
        {
            return GetApiDataAuthorized<IEnumerable<Node>>(NodeRoutes.GetNodesList());
        }

        public Task<Node> GetDetails(string nodeId)
        {
            return GetApiDataAuthorized<Node>(NodeRoutes.GetNodeDetails(nodeId));
        }

        public Task<Node> Create(NodeCreationData nodeCreationData)
        {
            return GetApiDataAuthorized<Node>(NodeRoutes.GetCreateNode(), nodeCreationData);
        }

        public async Task<bool> Delete(string nodeId)
        {
            return String.IsNullOrEmpty(await GetApiDataAuthorized<string>(NodeRoutes.GetDeleteNode(nodeId)));
        }

        public async Task<bool> Upgrade(string nodeId)
        {
            return String.IsNullOrEmpty(await GetApiDataAuthorized<string>(NodeRoutes.GetUpgradeNode(nodeId)));
        }
        
        public async Task<bool> Downgrade(string nodeId)
        {
            return String.IsNullOrEmpty(await GetApiDataAuthorized<string>(NodeRoutes.GetUpgradeNode(nodeId)));
        }

        public async Task<bool> Rebuild(string nodeId)
        {
            return String.IsNullOrEmpty(await GetApiDataAuthorized<string>(NodeRoutes.GetRebuildNode(nodeId)));
        }

        public Task<RewardsList> GetRewards(string nodeId, int pageNumber = 1)
        {
            return GetApiDataAuthorized<RewardsList>(NodeRoutes.GetNodeRewards(nodeId, pageNumber));
        }
    }
}