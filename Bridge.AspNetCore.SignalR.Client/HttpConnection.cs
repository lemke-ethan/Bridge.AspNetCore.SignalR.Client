using Bridge.AspNetCore.SignalR.Client.Threading;
using System;

namespace Bridge.AspNetCore.SignalR.Client
{
    [External]
    [Namespace("signalR")]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCase)]
    public class HttpConnection
    {
        #region Public Members

        /// <summary>
        /// HTTP connection features
        /// </summary>
        [Name("features")]
        public readonly object mFeatures = new object();

        #endregion

        #region Public Events

        /// <summary>
        /// Event that is fired when data is received
        /// </summary>
        [Name("onreceive")]
        public Action<object> mOnReceive;

        /// <summary>
        /// Event that is fired when the connection closes
        /// </summary>
        [Name("onclose")]
        public Action<object> mOnClose;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="url">URL to connect to</param>
        /// <param name="options">The connection options</param>
        public HttpConnection(string url, IHttpConnectionOptions options = null) { }

        #endregion

        #region Public Methods

        /// <summary>
        /// Start the HTTP connection
        /// </summary>
        public Promise Start()
        {
            return default(Promise);
        }

        /// <summary>
        /// Send data to the client
        /// </summary>
        /// <param name="data">The data to be sent</param>
        public Promise Send(object data)
        {
            return default(Promise);
        }

        /// <summary>
        /// Stop the HTTP connection
        /// </summary>
        public Promise Stop()
        {
            return default(Promise);
        }

        #endregion
    }
}
