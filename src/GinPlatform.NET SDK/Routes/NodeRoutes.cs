using System.Net.Http;

namespace GinPlatform.NET_SDK.Routes
{
    internal static class NodeRoutes
    {
        private static string GetNodeRoute()
        {
            return GinPlatformSettings.GinPlatformUrl + "/nodes";
        }

        private static string GetNodeIdRoute(string nodeId)
        {
            return GinPlatformSettings.GinPlatformUrl + $"/nodes/{nodeId}";
        }

        internal static HttpRequestMessage GetNodesList()
        {
            return new HttpRequestMessage(HttpMethod.Get, GetNodeRoute());
        }

        internal static HttpRequestMessage GetNodeDetails(string nodeId)
        {
            return new HttpRequestMessage(HttpMethod.Get, GetNodeIdRoute(nodeId));
        }

        internal static HttpRequestMessage GetCreateNode()
        {
            return new HttpRequestMessage(HttpMethod.Post, GetNodeRoute());
        }

        internal static HttpRequestMessage GetDeleteNode(string nodeId)
        {
            return new HttpRequestMessage(HttpMethod.Delete, GetNodeIdRoute(nodeId));
        }

        internal static HttpRequestMessage GetUpgradeNode(string nodeId)
        {
            return new HttpRequestMessage(HttpMethod.Post, $"{GetNodeIdRoute(nodeId)}/upgrade");
        }

        internal static HttpRequestMessage GetDowngradeNode(string nodeId)
        {
            return new HttpRequestMessage(HttpMethod.Post, $"{GetNodeIdRoute(nodeId)}/downgrade");
        }
    }
}