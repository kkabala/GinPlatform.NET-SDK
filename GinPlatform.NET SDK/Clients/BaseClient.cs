using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace GinPlatform.NET_SDK.Clients
{
    public abstract class BaseClient : IDisposable
    {
        protected readonly HttpClient httpClient;

        protected BaseClient()
        {
            httpClient = new HttpClient();
        }

        private string GetApiKey(string passedApiKey)
        {
            var key = String.IsNullOrEmpty(passedApiKey) ? GinPlatform.ApiKey : passedApiKey;
            if (String.IsNullOrEmpty(key))
            {
                throw new UnauthorizedAccessException(
                    "The gincoin api key was not set up (neither directly, nor in the GinPlatform class");
            }

            return key;
        }

        protected void SetAuthorizationHeader(string apiKey)
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GetApiKey(apiKey));
        }

        protected void SetJsonContentType()
        {
            httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json");
        }

        public void Dispose()
        {
            httpClient?.Dispose();
        }
    }
}
