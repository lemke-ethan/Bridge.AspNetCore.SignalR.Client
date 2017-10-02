using Bridge.AspNetCore.SignalR.Client.Enumerations;

namespace Bridge.AspNetCore.SignalR.Client.Interfaces
{
    /// <summary>
    /// Hub message model
    /// </summary>
    [External]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCamelCase)]
    public interface HubMessage
    {
        #region Public Methods

        /// <summary>
        /// The type of message
        /// </summary>
        MessageType Type { get; }

        /// <summary>
        /// The ID of the invocation
        /// </summary>
        string InvocationId { get; }

        #endregion
    }
}
