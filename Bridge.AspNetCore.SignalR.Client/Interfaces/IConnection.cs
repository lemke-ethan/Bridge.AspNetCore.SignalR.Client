using System;
using System.Threading.Tasks;

namespace Bridge.AspNetCore.SignalR.Client
{
    /// <summary>
    /// Methods and events used on a connection
    /// </summary>
    [External]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCase)]
    public interface IConnection
    {
        #region Public Methods

        /// <summary>
        /// Start the connection
        /// </summary>
        IPromise Start();

        /// <summary>
        /// Send data over the connection
        /// </summary>
        /// <param name="data">The data to be sent</param>
        IPromise Send(object data);

        /// <summary>
        /// Stop the connection
        /// </summary>
        void Stop();

        #endregion

        #region Public Events

        /// <summary>
        /// Event that is fired when a data is received
        /// </summary>
        event Action<object> OnReceive;

        /// <summary>
        /// Event that is fired when the connection is closed
        /// </summary>
        event Action<Error> OnClose;

        #endregion
    }
}
