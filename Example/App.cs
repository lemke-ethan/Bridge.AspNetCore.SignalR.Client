using Bridge.AspNetCore.SignalR.Client;

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

        }
     
        #endregion
    }
}