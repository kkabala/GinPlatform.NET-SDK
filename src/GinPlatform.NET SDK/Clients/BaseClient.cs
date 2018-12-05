using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GinPlatform.NET_SDK.Clients
{
	public abstract class BaseClient : IDisposable
	{
		protected readonly HttpClient httpClient;
		private static List<DateTime> apiRequestsTimes = new List<DateTime>();

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
			response.EnsureSuccessStatusCode();
			var jsonResponse = await response.Content.ReadAsStringAsync();
			return JsonConvert.DeserializeObject<T>(jsonResponse);
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