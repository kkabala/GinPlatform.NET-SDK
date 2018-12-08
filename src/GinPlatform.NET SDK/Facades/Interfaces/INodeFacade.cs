using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GinPlatform.NET_SDK.Models.Node;

namespace GinPlatform.NET_SDK.Facades.Interfaces
{
    public interface INodeFacade : IDisposable
    {
        Task<IEnumerable<Node>> GetAll();
        Task<Node> GetDetails(string nodeId);
        Task<Node> Create(NodeCreationData nodeCreationData);
        Task<bool> Delete(string nodeId);
        Task<bool> Upgrade(string nodeId);
        Task<bool> Downgrade(string nodeId);
        Task<bool> Rebuild(string nodeId);
        Task<RewardsList> GetRewards(string nodeId, int pageNumber = 1);
    }
}