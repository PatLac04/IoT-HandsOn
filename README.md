# IoT Hub Hands on Lab (HoL)

## Overview
This Hands on Lab (HOL) demonstrates the basic capabilities of [Azure IoT Hub](https://azure.microsoft.com/en-us/services/iot-hub/) and is targetted at developers.
- Create simulated device 
- Register device in IoTHub
- Send Telemetry (Device to Cloud)
- Receive Message (Cloud to Device)
- Play with IoTHub Routing
- Use Azure Stream Analytics to read from IoTHub
- Create Azure Function triggered by CosmosDB ChangeFeed.


## Lab Requirements

1. Microsoft Azure subscription (pay-as-you-go or MSDN). (https://azure.microsoft.com/en-ca/free/)
2. Visual Studio 2017 (15.7 or higher) or [Visual Studio Code](https://code.visualstudio.com/)
3. Azure Storage Explorer (https://azure.microsoft.com/en-us/features/storage-explorer/);
4. Service Bus Explorer (https://github.com/paolosalvatori/ServiceBusExplorer)

It is expected that you will have a base understanding of the following:
- Microsoft Azure (we will discuss the IoT specific aspects of Azure so are expecting attendees to understand Azure and the capabilities in a broader sense);
- Development experience in C#.

## Azure services and related products used in the labs
- Azure IoT Hub
- Service Bus
- Azure Storage
- Stream Analytics
- Logic App
- Azure Functions
- CosmosDB

### Environment Setup

The following subsections of the Hands on Labs are as follow: 

### Morning

 * [1 - Hands on Lab Setup](/HOL/IOTHubPiHackathon/1)

 * 2 - Provision **ONE** of the following:<br>
   * a) [A Remote Monitoring Solution Accelerator](/HOL/IOTHubPiHackathon/2) <BR>
   **OR**<br>
   * b) [An IoT Hub](/HOL/IOTHubPiHackathon/2b)<br>

 * [3 - Connect Raspberry Pi to Azure IoT](/HOL/IOTHubPiHackathon/3)

### Afternoon

 * 4 - Route your IoT data using Stream Analytics to one (or both) of the following:<br>
   * a) [Power BI](/HOL/IOTHubPiHackathon/StreamAnalytics)<BR>
   **OR**
   * b) [Blob Storage](/HOL/IOTHubPiHackathon/BlobStorage)

 * [5 - Azure Functions](/HOL/IOTHubPiHackathon/AzureFunction)
 
 * [6 - Lab Clean-up](/HOL/IOTHubPiHackathon/Cleanup)