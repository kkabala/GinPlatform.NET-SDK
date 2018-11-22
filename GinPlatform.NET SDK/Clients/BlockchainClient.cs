using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using GinPlatform.NET_SDK.Model.Blockchain;
using GinPlatform.NET_SDK.Routes;
using Newtonsoft.Json;

namespace GinPlatform.NET_SDK.Clients
{
    public class BlockchainClient : BaseClient
    {
        public async Task<IEnumerable<Blockchain>> GetAllBlockchains()
        {
            var blockchainsResponse = await httpClient.SendAsync(BlockchainRoutes.GetBlockchainsList());
            var blockchainsJson = await blockchainsResponse.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Blockchain>>(blockchainsJson);
        }

        public async Task<Blockchain> GetBlockchainDetails(string blockchainId)
        {
            var blockchainDetailsResponse = await httpClient.SendAsync(BlockchainRoutes.GetBlockchainDetails(blockchainId));
            var blockchainsDetailsJson = await blockchainDetailsResponse.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Blockchain>(blockchainsDetailsJson);
        }
    }
}