using System.Threading.Tasks;
using GinPlatform.NET_SDK.Model.User;
using GinPlatform.NET_SDK.Routes;

namespace GinPlatform.NET_SDK.Clients
{
    public class UserClient : BaseClient
    {
        public Task<User> GetDetails(string apiKey=null)
        {
            return GetApiDataAuthorized<User>(UserRoutes.GetCurrentUser(), apiKey);
        }

        public Task<TransactionsList> GetTransactionsList(int pageNumber,string apiKey=null)
        {
            return GetApiDataAuthorized<TransactionsList>(UserRoutes.GetTransactions(pageNumber), apiKey);
        }
    }
}
