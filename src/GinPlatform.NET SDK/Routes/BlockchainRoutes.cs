using System.Net.Http;

namespace GinPlatform.NET_SDK.Routes
{
    internal static class BlockchainRoutes
    {
        internal static HttpRequestMessage GetBlockchainsList()
        {
            return new HttpRequestMessage(HttpMethod.Get, $"{GinPlatformSettings.GinPlatformUrl}/blockchains");
        }

        internal static HttpRequestMessage GetBlockchainDetails(string blockchainId)
        {
            return new HttpRequestMessage(HttpMethod.Get, GinPlatformSettings.GinPlatformUrl + $"/blockchains/{blockchainId}");
        }
    }
}