using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using GinPlatform.NET_SDK.Model.Node;
using GinPlatform.NET_SDK.Routes;
using Newtonsoft.Json;

namespace GinPlatform.NET_SDK.Clients
{
    public class NodeClient : BaseClient
    {
        public async Task<IEnumerable<Node>> GetAllNodes(string apiKey = null)
        {
            SetAuthorizationHeader(apiKey);
            var nodesResponse = await httpClient.SendAsync(NodeRoutes.GetNodesList());
            var nodesJson = await nodesResponse.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Node>>(nodesJson);
        }
    }
}