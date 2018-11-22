using System.Net.Http;

namespace GinPlatform.NET_SDK.Routes
{
    public static class BlockchainRoutes
    {
        public static HttpRequestMessage GetBlockchainsList()
        {
            return new HttpRequestMessage(HttpMethod.Get, $"{MainRoutes.GIN_PLATFORM_URL}/blockchains");
        }

        public static HttpRequestMessage GetBlockchainDetails(string blockchainId)
        {
            return new HttpRequestMessage(HttpMethod.Get, MainRoutes.GIN_PLATFORM_URL + $"/blockchains/{blockchainId}");
        }
    }
}
