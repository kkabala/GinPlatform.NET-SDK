using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace GinPlatform.NET_SDK.Routes
{
    public static class NodeRoutes
    {
        private static string GetNodeRoute()
        {
            return GinPlatform.GIN_PLATFORM_URL + "/nodes";
        }

        private static string GetNodeIdRoute(string nodeId)
        {
            return GinPlatform.GIN_PLATFORM_URL + $"/nodes/{nodeId}";
        }
        public static HttpRequestMessage GetNodesList()
        {
            return new HttpRequestMessage(HttpMethod.Get, GetNodeRoute());
        }

        public static HttpRequestMessage GetNodeDetails(string nodeId)
        {
            return new HttpRequestMessage(HttpMethod.Get, GetNodeIdRoute(nodeId));
        }

        public static HttpRequestMessage GetCreateNode()
        {
            return new HttpRequestMessage(HttpMethod.Post, GetNodeRoute());
        }

        public static HttpRequestMessage GetDeleteNode(string nodeId)
        {
            return new HttpRequestMessage(HttpMethod.Delete, GetNodeIdRoute(nodeId));
        }

        public static HttpRequestMessage GetUpgradeNode(string nodeId)
        {
            return new HttpRequestMessage(HttpMethod.Post, $"{GetNodeIdRoute(nodeId)}/upgrade");
        }

        public static HttpRequestMessage GetDowngradeNode(string nodeId)
        {
            return new HttpRequestMessage(HttpMethod.Post, $"{GetNodeIdRoute(nodeId)}/downgrade");
        }
    }
}
