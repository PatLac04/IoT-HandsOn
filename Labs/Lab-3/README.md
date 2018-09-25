## Lab 3

In this lab, you will configure Routing in the IoTHub. Routing allows you to route messages to specified endpoints based on the values of fields in the messages.

We will configure 2 Routes:

- Alerts will trigger a Logic App to send an email
- Cold Path will save all messages to Blob Storage for archiving and analytics 

Since all the required resources have been created in the lab setup, all you have to do is follow the instructions for the following steps:

1) [Set up message routing](https://docs.microsoft.com/en-us/azure/iot-hub/tutorial-routing#set-up-message-routing)

   Don't create the Logic App yet!

   Start the SimulatedDevice application and use Service Bus Explorer to connect to your Service Bus and confirm the messages are added to your queue.

   Stop the application.

2) [Create a Logic App](https://docs.microsoft.com/en-us/azure/iot-hub/tutorial-routing#create-a-logic-app)

   Don't continue with the Stream Analytics creation, this is the next lab.

   Start the SimulatedDevice application and confirm you are receiving emails.

   Stop the application.

[Back to Main HOL Instructions](/README.md)