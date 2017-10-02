using Bridge.AspNetCore.SignalR.Client.Interfaces;

namespace Bridge.AspNetCore.SignalR.Client
{
    /// <summary>
    /// A hub connection
    /// </summary>
    [External]
    [Namespace("signalR")]
    public class HubConnection
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="url">The target URL</param>
        /// <param name="options">The connection options</param>
        public HubConnection(string url, IHubConnectionOptions options = null) { }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="url">A hub connection</param>
        /// <param name="options">The connection options</param>
        public HubConnection(IConnection url, IHubConnectionOptions options = null) { }

        #endregion
    }
}
