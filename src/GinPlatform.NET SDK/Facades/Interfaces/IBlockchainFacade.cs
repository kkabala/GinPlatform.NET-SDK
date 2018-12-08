using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GinPlatform.NET_SDK.Models.Blockchain;

namespace GinPlatform.NET_SDK.Facades.Interfaces
{
    public interface IBlockchainFacade : IDisposable
    {
        Task<IEnumerable<Blockchain>> GetAll();
        Task<Blockchain> GetDetails(string blockchainId);
    }
}