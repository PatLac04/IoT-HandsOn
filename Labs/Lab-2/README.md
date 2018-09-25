## Lab 2

Using the same code you used in the previous lab, read through the instructions at:
- [Quickstart: Control a device connected to an IoT hub (.NET)](https://docs.microsoft.com/en-us/azure/iot-hub/quickstart-control-device-dotnet);

The instructions are for Visual Studio Code so if you're using Visual Studio 2017, the instructions are a bit different but you should manage.

1) The solution provided already has the code to call a Direct Method from a Backend application to a Device. Look at the `SetTelemetryInterval` method and make sure you understand the code.

2) Follow the instructions from [Send messages from the cloud to your device with IoT Hub (.NET)](https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-csharp-csharp-c2d) to implement code to receive a *Cloud To Device* message.

### Optional exercises
1) By following the instructions from [Trigger a remote reboot on the device using a direct method
](https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-csharp-csharp-device-management-get-started#trigger-a-remote-reboot-on-the-device-using-a-direct-method), try to implement the logic in the provided applications.


Make sure you read this article to understand when to use **Direct Method** versus **Cloud to Device messages**.
- [Cloud-to-device communications guidance](https://docs.microsoft.com/en-ca/azure/iot-hub/iot-hub-devguide-c2d-guidance);
- [Schedule and broadcast jobs](https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-csharp-csharp-schedule-jobs)


[Back to Main HOL Instructions](/README.md)