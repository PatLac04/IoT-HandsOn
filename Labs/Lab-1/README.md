# Lab 1

For this lab, get the code from: [IoT-HandsOn](https://github.com/PatLac04/IoT-HandsOn). It would be beneficial to read the code to understand how it works but all you need to do is replace some values.

You can read through the instructions at [Send telemetry from a device to an IoT hub and read the telemetry from the hub with a back-end application (C#)](https://docs.microsoft.com/en-us/azure/iot-hub/quickstart-send-telemetry-dotnet) to understand how to create an IoTHub and register a device but use the code provided in this lab.

The instructions are for Visual Studio Code so if you're using Visual Studio 2017, the instructions are a bit different but you'll manage.

**Notes:**

- You already created your IoTHub when you ran the script in the setup. Navigate to the [Azure Portal](https://portal.azure.com), find your Resource Group and you should see your IoTHub.
- You also already registered a device called **Contoso-Gateway** in your IoTHub. When you're in the portal, click on your IoTHub and select IoT Devices in the resource blade as shown here:

   ![Cloud Shell from the portal](/Labs/images/iotdevice.png)
- You can get the Device connection string by either clicking on the device in the portal or by running the following command in the Cloud Shell

   ```azurecli-interactive
   az iot hub device-identity show-connection-string --hub-name {YourIoTHubName} --device-id MyDotnetDevice --output table
   ```

## Run the Simulated Device and Read the telemetry from your hub

1) Navigate to the location where you downloaded the source code and open the solution found in **IoT-HandsOn\Code\Lab1\IoT_SimulatedDevice.sln**.

2) You can also open the folder **IoT-HandsOn\Code\Lab1** in VSCode if you prefer.

3) Open the **Program.cs** file in the **SimulatedDevice** project and replace the value of the `s_connectionString` variable.

4) Compile and run the application

5) You should see messages being sent from the Simulated Device.

6) Open the **ReadDeviceToCloudMessages.cs** file in the **read_d2c_messages** project and replace the values of the `s_eventHubsCompatibleEndpoint`, `s_eventHubsCompatibleName` and `s_iotHubSasKey` variables.

7) Compile and run the application.

8) You should see messages being read from IoTHub.

9) **Make sure to stop both applications before continuing with the other labs.** 


**Note:** Don't cleanup the resources at the end since we will be re-using them in the other labs.

## More Resources

- [Device-to-cloud communications guidance](https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-d2c-guidance)
- [How to manage connectivity and reliable messaging using Azure IoT Hub device SDKs](https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-reliability-features-in-sdks)
- [Device-to-cloud communications guidance](https://docs.microsoft.com/en-ca/azure/iot-hub/iot-hub-devguide-d2c-guidance)

[Back to Main HOL Instructions](/README.md)