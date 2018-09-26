# IoT Hub Hands on Lab (HoL)

## Overview

This Hands on Lab (HOL) demonstrates the basic capabilities of [Azure IoT Hub](https://azure.microsoft.com/en-us/services/iot-hub/) and is targetted at developers.

- Create simulated device
- Register device in IoTHub
- Send Telemetry (Device to Cloud)
- Receive Message (Cloud to Device)
- IoTHub Routing
- Use Azure Stream Analytics to read from IoTHub
- Create Azure Function triggered by CosmosDB ChangeFeed.

This diagram shows what will be accomplished during the labs.

![Architecture Diagram](/Labs/images/diagram.png)

## Lab Requirements

1. Microsoft Azure subscription (pay-as-you-go or MSDN). (https://azure.microsoft.com/en-ca/free/);
2. Visual Studio 2017 (15.7 or higher) or [Visual Studio Code](https://code.visualstudio.com/);
3. Azure Storage Explorer (https://azure.microsoft.com/en-us/features/storage-explorer/);
4. Service Bus Explorer (https://github.com/paolosalvatori/ServiceBusExplorer).

It is expected that you will have a base understanding of the following:

- Microsoft Azure (we will discuss the IoT specific aspects of Azure so are expecting attendees to understand Azure and the capabilities in a broader sense);
- Development experience in C#.

## Azure services used in the labs

- Azure IoT Hub
- Service Bus
- Azure Storage
- Stream Analytics
- Logic App
- Azure Functions
- CosmosDB

## Environment Setup

Follow the instruction to setup the environment [here](/Labs/Setup/README.md).

## Hand-On Labs

1) [**Lab 1**](/Labs/Lab-1/README.md)

   In this lab, you will do the following:
   - Create a simulated device;
   - Register the device in IoTHub;
   - Send telemetry from the device.

2) [**Lab 2**](/Labs/Lab-2/README.md):
   - Receive Cloud to Device (C2D) message;
   - Receive a  Direct Method

3) [**Lab 3**](/Labs/Lab-3/README.md):
   - IoTHub Routing

4) [**Lab 4**](/Labs/Lab-4/README.md):
   - Azure Stream Analytics
   - CosmosDB

5) [**Lab 5**](/Labs/Lab-5/README.md):
   - CosmosDB ChangeFeed

6) [**Lab 6**](/Labs/Lab-6/README.md):
   - SignalR Integration
