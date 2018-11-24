using System.Dynamic;

namespace GinPlatform.NET_SDK
{
    internal static class GinPlatformSettings
    {
        internal static string GinPlatformUrl { get; set; }= "https://api.ginplatform.io";

        internal static string ApiKey { get; set; }

	    internal static bool ProtectionFromBeingRateLimited { get; set; } = true;
    }
}