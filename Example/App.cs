using Bridge.AspNetCore.SignalR.Client;
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
            // Connect to a hub
            var hubConnection = new HubConnection("/test");

            // Setup on data received event handler
            hubConnection.On("Send", (data) => 
            {
                // Log the received data to the console
                Console.WriteLine(data);
            });

            // Start the connection
            hubConnection.Start().Then(new Action(() =>
            {
                // Send a message
                hubConnection.Invoke("send", new object[] { "Hello" });
            }));

            // Stop the connection
            hubConnection.Stop();

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
            httpConnection.Start().Then(new Action(() => 
            {
                // Get the features
                var features = httpConnection.mFeatures;

                // Send a message
                httpConnection.Send("hello").Then(new Action(() => 
                {
                    // Stop the connection
                    httpConnection.Stop();
                }));
            }));
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