using System;
using System.Net.Http;
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