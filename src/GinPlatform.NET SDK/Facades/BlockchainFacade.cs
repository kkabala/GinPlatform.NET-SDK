using System.Collections.Generic;
using System.Threading.Tasks;
using GinPlatform.NET_SDK.Facades.Interfaces;
using GinPlatform.NET_SDK.Models.Blockchain;
using GinPlatform.NET_SDK.Routes;

namespace GinPlatform.NET_SDK.Facades
{
    internal class BlockchainFacade : BaseFacade, IBlockchainFacade
    {
        public Task<IEnumerable<Blockchain>> GetAll()
        {
            return GetApiData<IEnumerable<Blockchain>>(BlockchainRoutes.GetBlockchainsList());
        }

        public Task<Blockchain> GetById(string blockchainId)
        {
            return GetApiData<Blockchain>(BlockchainRoutes.GetBlockchainDetails(blockchainId));
        }
    }
}