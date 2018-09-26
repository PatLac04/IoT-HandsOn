# Lab 6

For this lab, you're on your own!  

The objective is to change the Azure Function created in Lab-5 to use [Azure SignalR](https://docs.microsoft.com/en-us/azure/azure-signalr/) to broadcast the updates to a client (WebApp).

The following diagram shows what needs to be done:

   ![SignalR Service bindings for Azure Functions](/Labs/images/signalr.png)

1) A change is made in a Cosmos DB collection
2) The change event is propagated to the Cosmos DB change feed
3) An Azure Functions is triggered by the change event using the Cosmos DB trigger
4) The SignalR Service output binding publishes a message to SignalR Service
5) SignalR Service publishes the message to all connected clients

## Useful Articles

You can start by reading the following articles:

- [Build Real-time Apps with Azure Functions and Azure SignalR Service](https://docs.microsoft.com/en-us/azure/azure-signalr/signalr-overview-azure-functions)
- [Quickstart: Create a chat room with Azure Functions and SignalR Service using C#](https://docs.microsoft.com/en-us/azure/azure-signalr/signalr-quickstart-azure-functions-csharp)

If you ever get desperate and can't figure it out after a few hours... You can also read [Anthony Chu's](https://twitter.com/nthonyChu) wonderful article that explains everything and provides you with the solution !

- [Broadcast Real-time Updates from Cosmos DB with SignalR Service and Azure Functions](https://anthonychu.ca/post/cosmosdb-real-time-azure-functions-signalr-service/)

[Back to Main HOL Instructions](/README.md)