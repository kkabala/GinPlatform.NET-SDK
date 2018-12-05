using System;
namespace GinPlatform.NET_SDK.Exceptions
{
    public class TooManyRequestsException : Exception
    {
        public TooManyRequestsException() : base("Too many requests. Please try again after 2 minutes")
        {
        }
    }
}
