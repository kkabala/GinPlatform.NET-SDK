using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using GinPlatform.NET_SDK.Exceptions;
using Newtonsoft.Json;

namespace GinPlatform.NET_SDK.Facades
{
    internal abstract class BaseAuthorizedFacade : BaseFacade
    {
        internal readonly string apiKey;

        internal BaseAuthorizedFacade(string apiKey)
        {
            this.apiKey = apiKey;
        }

        protected Task<T> GetApiDataAuthorized<T>(HttpRequestMessage message, object httpRequestContent)
        {
            SetAuthorizationHeader();
            message.Content = new StringContent(JsonConvert.SerializeObject(httpRequestContent), Encoding.UTF8, "application/json");
            return GetApiData<T>(message);
        }

        protected Task<T> GetApiDataAuthorized<T>(HttpRequestMessage message)
        {
            SetAuthorizationHeader();
            return GetApiData<T>(message);
        }

        private string GetApiKey(string passedApiKey)
        {
            if (String.IsNullOrEmpty(passedApiKey))
            {
                throw new UnauthorizedException(
                    "The gincoin api key was not set up (neither directly, nor in the GinPlatformSettings class");
            }

            return passedApiKey;
        }

        protected void SetAuthorizationHeader()
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", GetApiKey(apiKey));
        }
    }
}