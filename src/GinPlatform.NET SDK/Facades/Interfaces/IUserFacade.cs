using System;
using System.Threading.Tasks;
using GinPlatform.NET_SDK.Models.User;

namespace GinPlatform.NET_SDK.Facades.Interfaces
{
    public interface IUserFacade : IDisposable
    {
        Task<User> GetDetails();
        Task<TransactionsList> GetTransactionsList(int pageNumber = 1);
    }
}