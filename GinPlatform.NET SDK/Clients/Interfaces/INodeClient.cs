﻿using System;
using GinPlatform.NET_SDK.Model.Node;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GinPlatform.NET_SDK.Clients.Interfaces
{
    public interface INodeClient : IDisposable
    {
        Task<IEnumerable<Node>> GetAll(string apiKey = null);
        Task<Node> GetDetails(string nodeId, string apiKey = null);
        Task<Node> Create(NewNode newNode, string apiKey = null);
        Task<bool> Delete(string nodeId, string apiKey = null);
        Task<bool> Upgrade(string nodeId, string apiKey = null);
        Task<bool> Downgrade(string nodeId, string apiKey = null);
    }
}