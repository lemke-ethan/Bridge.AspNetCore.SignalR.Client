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
        }
     
        #endregion
    }
}