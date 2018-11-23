# GinPlatform.NET-SDK
GinPlatform.NET SDK is a pack of c# wrappings around GinPlatform REST API: https://docs.ginplatform.io/

The SDK covers all endpoints of the API. It enables you to do the same things as you can do using the API, but in more .NET object oriented way.

The whole magic lays in "Client" classes. Those are your starting point and the place where interaction with the platform API happens.
For now the list of available clients (with functionalities) is as below:
- BlockchainClient:
  - GetAll()
  - GetDetails(string blockchainId)
- NodeClient:
  - GetAll(string apiKey = null)
  - GetDetails(string nodeId, string apiKey = null)
  - Create(NewNode newNode, string apiKey = null)
  - Delete(string nodeId, string apiKey = null)
  - Upgrade(string nodeId, string apiKey = null)
  - Downgrade(string nodeId, string apiKey = null)
- UserClient:
  - GetDetails(string apiKey = null)
  - GetTransactionsList(int pageNumber, string apiKey = null)
  
Apart from that you have "GinPlatform" class when you can store your apiKey to be reused by all clients (in case you don't want to pass the same apiKey to a client's method every single time).

The documentation with samples is going to be provided soon.

Suggestions & testing are more than welcomed.

If you like the SDK, consider a donation in GIN, which will allow me to test the SDK properly though making it more solid and reliable (as setting up nodes on the platform costs some GIN): <b>GebkJ4vC7pa5W5uesY5qst2svpS1xZCqjH</b>
