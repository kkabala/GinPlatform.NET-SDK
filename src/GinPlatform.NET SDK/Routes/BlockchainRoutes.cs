using System.Net.Http;

namespace GinPlatform.NET_SDK.Routes
{
    internal static class BlockchainRoutes
    {
        internal static HttpRequestMessage GetBlockchainsList()
        {
            return new HttpRequestMessage(HttpMethod.Get, $"{GinPlatform.GIN_PLATFORM_URL}/blockchains");
        }

        internal static HttpRequestMessage GetBlockchainDetails(string blockchainId)
        {
            return new HttpRequestMessage(HttpMethod.Get, GinPlatform.GIN_PLATFORM_URL + $"/blockchains/{blockchainId}");
        }
    }
}