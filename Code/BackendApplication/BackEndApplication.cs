// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

// This application uses the Azure IoT Hub service SDK for .NET
// For samples see: https://github.com/Azure/azure-iot-sdk-csharp/tree/master/iothub/service
using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Devices;

namespace back_end_application
{
    class BackEndApplication
    {
        private static ServiceClient s_serviceClient;
        
        // Connection string for your IoT Hub
        // az iot hub show-connection-string --hub-name {your iot hub name}
        private readonly static string s_connectionString = "{IoTHub Connection String}";
        private readonly static string s_myDeviceId = "Contoso-Test-Device";

        private static void Main(string[] args)
        {
            Console.WriteLine("IoT Hub Quickstarts #2 - Back-end application.\n");

            // Create a ServiceClient to communicate with service-facing endpoint on your hub.
            s_serviceClient = ServiceClient.CreateFromConnectionString(s_connectionString);
            ReceiveFeedbackAsync();

            Console.WriteLine("Press any key to send a C2D message.");
            Console.ReadLine();
            SendCloudToDeviceMessageAsync().Wait();

            Console.WriteLine("Press any key to call a Method on the Device");
            Console.ReadLine();
            SetTelemetryInterval().GetAwaiter().GetResult();

            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }

        private async static Task SendCloudToDeviceMessageAsync()
        {
            Console.WriteLine("\nSending c2d message from service\n");

            var commandMessage = new Message(Encoding.ASCII.GetBytes("Cloud to device message."));
            commandMessage.Ack = DeliveryAcknowledgement.Full;

            await s_serviceClient.SendAsync(s_myDeviceId, commandMessage);
        }

        private async static void ReceiveFeedbackAsync()
        {
            var feedbackReceiver = s_serviceClient.GetFeedbackReceiver();

            Console.WriteLine("\nReceiving c2d feedback from service\n");
            while (true)
            {
                var feedbackBatch = await feedbackReceiver.ReceiveAsync();
                if (feedbackBatch == null) continue;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Received feedback: {0}",
                  string.Join(", ", feedbackBatch.Records.Select(f => f.StatusCode)));
                Console.ResetColor();

                await feedbackReceiver.CompleteAsync(feedbackBatch);
            }
        }

        // Invoke the direct method on the device, passing the payload
        private static async Task SetTelemetryInterval()
        {
            Console.WriteLine("\nCalling Method SetTelemetryInterval on device\n");

            var methodInvocation = new CloudToDeviceMethod("SetTelemetryInterval") { ResponseTimeout = TimeSpan.FromSeconds(30) };
            methodInvocation.SetPayloadJson("10");

            // Invoke the direct method asynchronously and get the response from the simulated device.
            var response = await s_serviceClient.InvokeDeviceMethodAsync(s_myDeviceId, methodInvocation);

            Console.WriteLine("Response status: {0}, payload:", response.Status);
            Console.WriteLine(response.GetPayloadAsJson());
        }

    }
}
