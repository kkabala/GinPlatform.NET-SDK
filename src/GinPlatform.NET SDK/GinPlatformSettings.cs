namespace GinPlatform.NET_SDK
{
    public static class GinPlatformSettings
    {
        public static string GinPlatformUrl { get; set; }= "https://api.ginplatform.io";

        public static string ApiKey { get; set; }

	    public static bool ProtectionFromBeingRateLimited { get; set; } = true;
    }
}