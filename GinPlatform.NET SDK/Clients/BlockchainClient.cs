﻿using System;
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
        public Task<IEnumerable<Blockchain>> GetAll()
        {
            return GetApiData<IEnumerable<Blockchain>>(BlockchainRoutes.GetBlockchainsList());
        }

        public Task<Blockchain> GetDetails(string blockchainId)
        {
            return GetApiData<Blockchain>(BlockchainRoutes.GetBlockchainDetails(blockchainId));
        }
    }
}