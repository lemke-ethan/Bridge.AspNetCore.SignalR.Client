using Bridge.AspNetCore.SignalR.Client.Interfaces;
using Bridge.AspNetCore.SignalR.Client.Enumerations;

namespace Bridge.AspNetCore.SignalR.Client
{
    /// <summary>
    /// The Json hub protocol
    /// </summary>
    [External]
    [Namespace("signalR")]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCamelCase)]
    public class JsonHubProtocol : IHubProtocol
    {
        #region IHubProtocol Implementation

        #region Public Properties

        /// <summary>
        /// Name of the protocol
        /// </summary>
        public string Name => "json";

        /// <summary>
        /// Type of the protocol
        /// </summary>
        public ProtocolType Type => ProtocolType.Text;

        #endregion

        #region Public Methods

        /// <summary>
        /// Parse the JSON messages
        /// </summary>
        /// <param name="any">The messages</param>
        /// <returns>The parsed messages</returns>
        public HubMessage[] ParseMessages(object any)
        {
            return default(HubMessage[]);
        }

        /// <summary>
        /// Write a message
        /// </summary>
        /// <param name="message">The message to be written</param>
        /// <returns>JSON message</returns>
        public object WriteMessage(HubMessage message)
        {
            return default(object);
        }

        #endregion

        #endregion
    }
}
