using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using GinPlatform.NET_SDK.Exceptions;
using Newtonsoft.Json;

namespace GinPlatform.NET_SDK.Clients
{
    public abstract class BaseAuthorizedClient : BaseClient
    {
        protected Task<T> GetApiDataAuthorized<T>(HttpRequestMessage message, object httpRequestContent, string apiKey = null)
        {
            SetAuthorizationHeader(apiKey);
            message.Content = new StringContent(JsonConvert.SerializeObject(httpRequestContent), Encoding.UTF8, "application/json");
            return GetApiData<T>(message);
        }

        protected Task<T> GetApiDataAuthorized<T>(HttpRequestMessage message, string apiKey = null)
        {
            SetAuthorizationHeader(apiKey);
            return GetApiData<T>(message);
        }

        private string GetApiKey(string passedApiKey)
        {
            var key = String.IsNullOrEmpty(passedApiKey) ? GinPlatformSettings.ApiKey : passedApiKey;
            if (String.IsNullOrEmpty(key))
            {
                throw new UnauthorizedException(
                    "The gincoin api key was not set up (neither directly, nor in the GinPlatformSettings class");
            }

            return key;
        }

        protected void SetAuthorizationHeader(string apiKey)
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GetApiKey(apiKey));
        }
    }
}