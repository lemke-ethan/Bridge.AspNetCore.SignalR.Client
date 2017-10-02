using Bridge.AspNetCore.SignalR.Client.Enumerations;

namespace Bridge.AspNetCore.SignalR.Client.Interfaces
{
    /// <summary>
    /// Protocol for communicating over the hub
    /// </summary>
    [External]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCamelCase)]
    public interface IHubProtocol
    {
        #region Public Properties

        /// <summary>
        /// The name of the protocol
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The type of the protocol
        /// </summary>
        ProtocolType Type { get; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Parses the messages sent over the hub
        /// </summary>
        /// <param name="any">Messages to be parsed</param>
        /// <returns>The collection of hub messages</returns>
        HubMessage[] ParseMessages(object any);

        /// <summary>
        /// Write a hub message
        /// </summary>
        /// <param name="message">The hub message</param>
        /// <returns>Message object</returns>
        object WriteMessage(HubMessage message);

        #endregion
    }
}
