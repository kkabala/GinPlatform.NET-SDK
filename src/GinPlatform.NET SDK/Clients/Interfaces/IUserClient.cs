using System;
using System.Threading.Tasks;
using GinPlatform.NET_SDK.Models.User;

namespace GinPlatform.NET_SDK.Clients.Interfaces
{
    public interface IUserClient : IDisposable
    {
        Task<User> GetDetails(string apiKey = null);
        Task<TransactionsList> GetTransactionsList(int pageNumber, string apiKey = null);
    }
}