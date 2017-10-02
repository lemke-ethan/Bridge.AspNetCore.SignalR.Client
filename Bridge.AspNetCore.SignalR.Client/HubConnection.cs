using Bridge.AspNetCore.SignalR.Client.Interfaces;
using Bridge.AspNetCore.SignalR.Client.Threading;
using System;

namespace Bridge.AspNetCore.SignalR.Client
{
    /// <summary>
    /// A hub connection
    /// </summary>
    [External]
    [Namespace("signalR")]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCamelCase)]
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

        #region Public Methods

        /// <summary>
        /// Start the hub connection
        /// </summary>
        public Promise Start()
        {
            return default(Promise);
        }

        /// <summary>
        /// Stop the hub connection
        /// </summary>
        public void Stop() { }

        /// <summary>
        /// Stream data of type <see cref="T"/>
        /// </summary>
        /// <typeparam name="T">The type of data to be streamed</typeparam>
        /// <param name="methodName">The method name</param>
        /// <param name="args">The method arguments</param>
        /// <returns>An observable object instance</returns>
        public Observable<T> Stream<T>(string methodName, object[] args)
        {
            return default(Observable<T>);
        }
        
        public Promise Send(string methodName, object[] args)
        {
            return default(Promise);
        }
        
        public Promise<object> Invoke(string methodName, object[] args)
        {
            return default(Promise<object>);
        }

        public void On(string methodName, Action<object[]> method) { }

        public void Off(string methodName, Action<object[]> method) { }

        /// <summary>
        /// Registers an event handler to the hub connection is closed event
        /// </summary>
        /// <param name="callback">Action to invoke</param>
        public void OnClose(Action<Error> callback) { }

        #endregion
    }
}
