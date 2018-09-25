## Lab 1

For this lab, get the code from: https://github.com/PatLac04/IoT-HandsOn. It would be beneficial to read the code to understand how it works but all you need to do is replace some values.

Read through the instructions at [Send telemetry from a device to an IoT hub and read the telemetry from the hub with a back-end application (C#)](https://docs.microsoft.com/en-us/azure/iot-hub/quickstart-send-telemetry-dotnet).

The instructions are for Visual Studio Code so if you're using Visual Studio 2017, the instructions are a bit different but you should manage.

**Notes:**

- You already created your IoTHub when you ran the script in the setup. Navigate to the [Azure Portal](https://portal.azure.com), find your Resource Group and you should see your IoTHub.
- You also already registered a device called **Contoso-Test-Device** in your IoTHub. When you're in the portal, click on your IoTHub and select IoT Devices in the resource blade as shown here:

   ![Cloud Shell from the portal](/Labs/images/iotdevice.png)
- You can get the Device connection string by either clicking on the device in the portal or by running the following command in the Cloud Shell

   ```azurecli-interactive
   az iot hub device-identity show-connection-string --hub-name {YourIoTHubName} --device-id MyDotnetDevice --output table
   ```

- Make sure you don't cleanup the resources at the end since we will be re-using them in the other labs.

### More Resources

- [Device-to-cloud communications guidance](https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-d2c-guidance)
- [How to manage connectivity and reliable messaging using Azure IoT Hub device SDKs](https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-reliability-features-in-sdks)
- [Device-to-cloud communications guidance](https://docs.microsoft.com/en-ca/azure/iot-hub/iot-hub-devguide-d2c-guidance)


[Back to Main HOL Instructions](/README.md)