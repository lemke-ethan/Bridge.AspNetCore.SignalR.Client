using Bridge.AspNetCore.SignalR.Client;
using Bridge.AspNetCore.SignalR.Client.Enumerations;
using System;

namespace Example
{
    /// <summary>
    /// Example application
    /// </summary>
    public class App
    {
        #region Pubic Static Methods

        /// <summary>
        /// Main entry point of the application
        /// </summary>
        public static void Main()
        {
            HubConnectionExample();
            HttpConnectionExample();
            JsonHubProtocolExample();
        }

        #endregion

        #region Private Static Methods

        /// <summary>
        /// <see cref="HubConnection"/> examples
        /// </summary>
        private static void HubConnectionExample()
        {
            // Connect to a hub
            var hubConnection = new HubConnection("/test");

            // Setup on data received event handler
            hubConnection.On("Send", (data) =>
            {
                // Log the received data to the console
                Console.WriteLine(data);
            });

            // Start the connection
            hubConnection.Start().Then(
                onfulfilled: () =>
                {
                    // Send a message
                    hubConnection.Invoke("send", new object[] { "Hello" });
                }, 
                onrejected: null);

            // Stop the connection
            hubConnection.Stop();
        }

        /// <summary>
        /// <see cref="HttpConnection"/> examples
        /// </summary>
        private static void HttpConnectionExample()
        {
            // Create an HTTP connection
            var httpConnection = new HttpConnection("/foo")
            {
                // Setup the close event handler
                mOnClose = (data) =>
                {
                    Console.WriteLine(data);
                },

                // Setup the data received event handler
                mOnReceive = HttpConnection_OnReceive
            };

            // Start the connection
            httpConnection.Start().Then(
                onfulfilled: () =>
                {
                    // Get the features
                    var features = httpConnection.mFeatures;

                    // Send a message
                    httpConnection.Send("hello").Then(
                        onfulfilled: () =>
                        {
                            // Stop the connection
                            httpConnection.Stop();
                        },
                        onrejected: null);
                },
                onrejected: null);
        }

        /// <summary>
        /// <see cref="JsonHubProtocol"/> examples
        /// </summary>
        private static void JsonHubProtocolExample()
        {
            // Create a new JSON hub
            var jsonHub = new JsonHubProtocol();

            // Get the hub's protocol name
            var protocolName = jsonHub.Name;
            
            // Get the hub's protocol type
            var protocolType = jsonHub.Type;

            // Create a new hub message
            var hubMessage = new HubMessage
            {
                InvocationId = "34lknl23k",
                Type = (MessageType)1
            };

            // Write a message
            var message = jsonHub.WriteMessage(hubMessage);

            // Parse a message
            var parsedMessage = jsonHub.ParseMessages(message);
        }

        /// <summary>
        /// On data received handler
        /// </summary>
        /// <param name="arg">The data that has been received</param>
        private static void HttpConnection_OnReceive(object arg)
        {
            // Log the data
            Console.WriteLine(arg);
        }

        #endregion
    }
}