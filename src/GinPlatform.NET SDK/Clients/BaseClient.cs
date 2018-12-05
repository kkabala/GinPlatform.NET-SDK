using GinPlatform.NET_SDK.Exceptions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace GinPlatform.NET_SDK.Clients
{
    public abstract class BaseClient : IDisposable
    {
        protected readonly HttpClient httpClient;
        private static List<DateTime> apiRequestsTimes = new List<DateTime>();
        static bool wasRateLimited = false;

        protected BaseClient()
        {
            httpClient = new HttpClient();
        }

        protected async Task<T> GetApiData<T>(HttpRequestMessage requestMessage)
        {
            if (GinPlatformSettings.ProtectionFromBeingRateLimited)
            {
                await Task.Delay(GetTimeNeededToWaitToEvadeRateLimiting());
            }
            AddNewRequestTime();
            var response = await httpClient.SendAsync(requestMessage);
            await EnsureSuccessStatusCode(response);

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(jsonResponse);
        }

        private async Task EnsureSuccessStatusCode(HttpResponseMessage response)
        {
            if (response.IsSuccessStatusCode)
            {
                return;
            }

            var content = await response.Content.ReadAsStringAsync();
            response.Content?.Dispose();

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedException(content);
            }

            if (response.StatusCode == HttpStatusCode.Forbidden)
            {
                throw new ForbiddenException(content);
            }

            if (response.StatusCode == HttpStatusCode.NotFound)
            {
                throw new NotFoundException(content);
            }

            if ((int)response.StatusCode == 429)
            {
                wasRateLimited = true;
                throw new TooManyRequestsException();
            }

            if ((int)response.StatusCode >= 400 && (int)response.StatusCode < 500)
            {
                throw new NotFoundException(content);
            }

            throw new GinPlatformApiException(response.StatusCode, content);
        }

        private void AddNewRequestTime()
        {
            if (apiRequestsTimes.Count == Rules.MaxRequestsPerMinute)
            {
                apiRequestsTimes.RemoveAt(0);
            }
            apiRequestsTimes.Add(DateTime.Now);
        }

        private TimeSpan GetTimeNeededToWaitToEvadeRateLimiting()
        {
            if (wasRateLimited)
            {
                wasRateLimited = false;
                return TimeSpan.FromMinutes(1);
            }
            var orderedApiRequestsTimes = apiRequestsTimes.OrderByDescending(m => m).ToList();
            var actualTime = DateTime.Now;

            bool isMaxRequestsPerSecondRuleViolated = false;
            TimeSpan theOldestRequestInPerSecondRule;
            if (orderedApiRequestsTimes.Count >= Rules.MaxRequestsPerSecond - 1)
            {
                theOldestRequestInPerSecondRule = actualTime.Subtract(orderedApiRequestsTimes
                    .Skip(Rules.MaxRequestsPerSecond - 2).First());

                isMaxRequestsPerSecondRuleViolated = theOldestRequestInPerSecondRule < TimeSpan.FromSeconds(1);
            }

            bool isMaxRequestsPerMinuteRuleViolated = false;
            TimeSpan theOldestRequestInPerMinuteRule;
            if (orderedApiRequestsTimes.Count >= Rules.MaxRequestsPerMinute - 1)
            {
                theOldestRequestInPerMinuteRule = actualTime.Subtract(orderedApiRequestsTimes
                    .Skip(Rules.MaxRequestsPerMinute - 2).First());

                isMaxRequestsPerMinuteRuleViolated = theOldestRequestInPerMinuteRule < TimeSpan.FromMinutes(1);
            }

            var timeToWaitInMilliseconds = Math.Max(
                isMaxRequestsPerSecondRuleViolated ? (TimeSpan.FromSeconds(1) - theOldestRequestInPerSecondRule).TotalMilliseconds : 0,
                isMaxRequestsPerMinuteRuleViolated ? (TimeSpan.FromMinutes(1) - theOldestRequestInPerMinuteRule).TotalMilliseconds : 0);

            return TimeSpan.FromMilliseconds(timeToWaitInMilliseconds);

        }

        public void Dispose()
        {
            httpClient?.Dispose();
        }
    }
}