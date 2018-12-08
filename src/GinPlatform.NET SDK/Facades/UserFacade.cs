using GinPlatform.NET_SDK.Routes;
using System.Threading.Tasks;
using GinPlatform.NET_SDK.Facades.Interfaces;
using GinPlatform.NET_SDK.Models.User;

namespace GinPlatform.NET_SDK.Facades
{
    internal class UserFacade : BaseAuthorizedFacade, IUserFacade
    {
        internal UserFacade(string apiKey) : base(apiKey)
        {
        }

        public Task<User> GetDetails()
        {
            return GetApiDataAuthorized<User>(UserRoutes.GetCurrentUser());
        }

        public Task<TransactionsList> GetTransactionsList(int pageNumber = 1)
        {
            return GetApiDataAuthorized<TransactionsList>(UserRoutes.GetTransactions(pageNumber));
        }
    }
}