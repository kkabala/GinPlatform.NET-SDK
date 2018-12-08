# GinPlatform.NET-SDK
GinPlatform.NET SDK is a pack of c# wrappings around GinPlatform REST API: https://docs.ginplatform.io/

The SDK covers all endpoints of the API. It enables you to do the same things as you can do using the API, but in more .NET object oriented way.

The whole magic lays in "Client" class. This is your starting point and the place where interaction with the platform API happens:

```C#
string apiKey = "...secret...";
var client = new Client(apiKey);

await client.Blockchains.GetAll(); //get blockchains list
await client.Blockchains.GetById("gincoin"); //get the gincoin blockchain

await client.Nodes.GetAll(); //get all my nodes
await client.Nodes.GetById("replace-with-node-id"); //get all my nodes
await client.Nodes.Create(new NodeCreationData(true, "gincoin", 1000, "tx-id-here", null));
await client.Nodes.Update(new NodeUpdate("replace-with-node-id", "replace-with-node-name", new Dictionary<string, string>() { { "key1", "value1" } })); //update a node
await client.Nodes.Delete("replace-with-node-id"); //delete a node

await client.User.GetDetails(); //get current user's details
await client.User.GetTransactionsList(); //get current user's billing transactions
```
  
Apart from that you have "GinPlatformSettings" class where you can:
  - Disable protection from being rate limited (ProtectionFromBeingRateLimited property) - it's enabled by default. It protects you from being rate limited as when you reach requests limit and trying to send a rule breaking request, the SDK calculates and waits required time to send the request to GinPlatform. Remember that it bases on request sending time, not the time of receiving it by the GinPlatform, therefore with the protection you won't achieve maximum possible requests per second/minute ratio, but you can be sure that you won't be rate limited.
  - Decrease/Increase your requests per second/minute limit - but the SDK won't allow you to set higher value than API limits. Requests per second are by default limited by half comparing to the API limit
  - Change GinPlatformUrl - not needed for now, but probably someday it'll be useful, for changing to stage/dev environment for example

If you like the SDK, consider a donation in GIN, which will allow me to test the SDK properly though making it more solid and reliable (as setting up nodes on the platform costs some GIN): <b>GebkJ4vC7pa5W5uesY5qst2svpS1xZCqjH</b>
