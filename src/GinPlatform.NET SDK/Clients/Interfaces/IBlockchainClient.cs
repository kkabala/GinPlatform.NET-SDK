using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GinPlatform.NET_SDK.Model.Blockchain;

namespace GinPlatform.NET_SDK.Clients.Interfaces
{
    public interface IBlockchainClient : IDisposable
    {
        Task<IEnumerable<Blockchain>> GetAll();
        Task<Blockchain> GetDetails(string blockchainId);
    }
}