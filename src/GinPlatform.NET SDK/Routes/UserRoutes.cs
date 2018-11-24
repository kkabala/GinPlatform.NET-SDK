using System.Net.Http;

namespace GinPlatform.NET_SDK.Routes
{
    internal static class UserRoutes
    {
        internal static HttpRequestMessage GetCurrentUser()
        {
            return new HttpRequestMessage(HttpMethod.Get, $"{GinPlatformSettings.GinPlatformUrl}/user");
        }

        internal static HttpRequestMessage GetTransactions(int pageNumber)
        {
            return new HttpRequestMessage(HttpMethod.Get, $"{GinPlatformSettings.GinPlatformUrl}/user/transactions?page={pageNumber}");
        }
    }
}