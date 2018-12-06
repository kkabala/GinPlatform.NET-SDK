namespace GinPlatform.NET_SDK
{
    public static class GinPlatformSettings
    {
        public static string GinPlatformUrl { get; set; }= "https://api.ginplatform.io";

        public static string ApiKey { get; set; }

	    public static bool ProtectionFromBeingRateLimited { get; set; } = true;
        private static int maxRequestsPerSecond = Rules.MAX_REQUESTS_PER_SECOND_API_THRESHOLD;

        public static int MaxRequestsPerSecond
        {
            get => maxRequestsPerSecond;
            set
            {
                if (value > Rules.MAX_REQUESTS_PER_SECOND_API_THRESHOLD)
                {
                    return;
                }
                maxRequestsPerSecond = value;
            }
        }

        private static int maxRequestsPerMinute = Rules.MAX_REQUESTS_PER_MINUTE_API_THRESHOLD;

        public static int MaxRequestsPerMinute
        {
            get => maxRequestsPerMinute;
            set
            {
                if (value > Rules.MAX_REQUESTS_PER_MINUTE_API_THRESHOLD)
                {
                    return;
                }
                maxRequestsPerMinute = value;
            }
        }
    }
}