using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

        public Task<T> GetApiDataAuthorized<T>(HttpRequestMessage message, string apiKey = null)
        {
            SetAuthorizationHeader(apiKey);
            return GetApiData<T>(message);
        }

        public Task<T> GetApiDataAuthorized<T>(HttpRequestMessage message, object httpRequestContent, string apiKey = null)
        {
            SetAuthorizationHeader(apiKey);
            message.Content = new StringContent(JsonConvert.SerializeObject(httpRequestContent));
            SetJsonContentType();
            return GetApiData<T>(message);
        }

        protected async Task<T> GetApiData<T>(HttpRequestMessage requestMessage)
        {
            var response = await httpClient.SendAsync(requestMessage);
            response.EnsureSuccessStatusCode();
            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }

        public void Dispose()
        {
            httpClient?.Dispose();
        }
    }
}