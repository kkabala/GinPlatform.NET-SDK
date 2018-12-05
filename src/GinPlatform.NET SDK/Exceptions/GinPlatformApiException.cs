using System;
using System.Net;

namespace GinPlatform.NET_SDK.Exceptions
{
    public class GinPlatformApiException : Exception
    {
        public HttpStatusCode StatusCode { get; set; }

        public GinPlatformApiException(HttpStatusCode statusCode, string content) : base(content)
        {
            StatusCode = statusCode;
        }
    }
}