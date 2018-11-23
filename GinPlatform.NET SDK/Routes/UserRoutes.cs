using System.Net.Http;

namespace GinPlatform.NET_SDK.Routes
{
    public static class UserRoutes
    {
        public static HttpRequestMessage GetCurrentUser()
        {
            return new HttpRequestMessage(HttpMethod.Get, $"{GinPlatform.GIN_PLATFORM_URL}/user");
        }

        public static HttpRequestMessage GetTransactions(int pageNumber)
        {
            return new HttpRequestMessage(HttpMethod.Get, $"{GinPlatform.GIN_PLATFORM_URL}/user/transactions?page={pageNumber}");
        }
    }
}