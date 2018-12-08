using GinPlatform.NET_SDK.Facades;
using GinPlatform.NET_SDK.Facades.Interfaces;

namespace GinPlatform.NET_SDK
{
    public class Client
    {
        private readonly string apiKey;

        public Client(string apiKey)
        {
            this.apiKey = apiKey;
        }

        private IBlockchainFacade blockchains;
        public IBlockchainFacade Blockchains
        {
            get
            {
                if (blockchains == null)
                {
                    blockchains = new BlockchainFacade();
                }
                return blockchains;
            }
        }

        private INodeFacade nodes;
        public INodeFacade Nodes
        {
            get
            {
                if (nodes == null)
                {
                    nodes = new NodeFacade(apiKey);
                }
                return nodes;
            }
        }

        private IUserFacade user;
        public IUserFacade User
        {
            get
            {
                if (user == null)
                {
                    user = new UserFacade(apiKey);
                }
                return user;
            }
        }
    }
}
