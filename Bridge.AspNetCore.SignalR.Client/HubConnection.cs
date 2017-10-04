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
        public IPromise Start()
        {
            return default(IPromise);
        }

        /// <summary>
        /// Stop the hub connection
        /// </summary>
        public void Stop() { }

        /// <summary>
        /// Stream data of type <see cref="T"/> to the server side method
        /// </summary>
        /// <typeparam name="T">The type of data to be streamed</typeparam>
        /// <param name="methodName">The method name</param>
        /// <param name="args">The method arguments</param>
        /// <returns>An observable object instance</returns>
        public Observable<T> Stream<T>(string methodName, params object[] args)
        {
            return default(Observable<T>);
        }
        
        /// <summary>
        /// Call a server side method with the specified arguments
        /// </summary>
        /// <param name="methodName">The name of the method</param>
        /// <param name="args">The arguments to be passed to the method</param>
        public IPromise Send(string methodName, params object[] args)
        {
            return default(IPromise);
        }

        /// <summary>
        /// Invoke a server side method with the specified arguments
        /// </summary>
        /// <param name="methodName">The name of the method</param>
        /// <param name="args">The arguments to be passed to the method</param>
        /// <returns>The method result</returns>
        public IPromise<object> Invoke(string methodName, params object[] args)
        {
            return default(IPromise<object>);
        }

        /// <summary>
        /// Bind a delegate to the method name
        /// </summary>
        /// <param name="methodName">The name of the method</param>
        /// <param name="method">The method signature and body</param>
        public void On(string methodName, Delegate method) { }

        public void Off(string methodName, Delegate method) { }

        /// <summary>
        /// Registers an event handler to the hub connection is closed event
        /// </summary>
        /// <param name="callback">Action to invoke</param>
        public void OnClose(Action<Error> callback) { }

        #endregion
    }
}
