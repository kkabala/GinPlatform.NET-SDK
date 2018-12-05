namespace GinPlatform.NET_SDK
{
    internal static class Rules
    {
        public const int MAX_REQUESTS_PER_SECOND_API_THRESHOLD = 4;
        public const int MAX_REQUESTS_PER_MINUTE_API_THRESHOLD= 120;

        private static int maxRequestsPerSecond = MAX_REQUESTS_PER_SECOND_API_THRESHOLD;

        public static int MaxRequestsPerSecond
        {
            get => maxRequestsPerSecond;
            set
            {
                if (value > MAX_REQUESTS_PER_SECOND_API_THRESHOLD)
                {
                    return;
                }
                maxRequestsPerSecond = value;
            }
        }

        private static int maxRequestsPerMinute = MAX_REQUESTS_PER_MINUTE_API_THRESHOLD;

        public static int MaxRequestsPerMinute
        {
            get => maxRequestsPerMinute;
            set
            {
                if (value > MAX_REQUESTS_PER_MINUTE_API_THRESHOLD)
                {
                    return;
                }
                maxRequestsPerMinute = value;
            }
        }
    }
}