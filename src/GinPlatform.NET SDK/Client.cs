using GinPlatform.NET_SDK.Facades;
using GinPlatform.NET_SDK.Facades.Interfaces;

namespace GinPlatform.NET_SDK
{
    public class Client
    {
        public static string ApiKey;
        private readonly string apiKey;

        public Client(string apiKey = null)
        {
            this.apiKey = apiKey ?? ApiKey;
        }

        private IBlockchainFacade blockchains;
        public IBlockchainFacade Blockchains => blockchains ?? (blockchains = new BlockchainFacade());

        private INodeFacade nodes;
        public INodeFacade Nodes => nodes ?? (nodes = new NodeFacade(apiKey));

        private IUserFacade user;
        public IUserFacade User => user ?? (user = new UserFacade(apiKey));
    }
}