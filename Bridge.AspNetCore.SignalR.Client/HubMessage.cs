using Bridge.AspNetCore.SignalR.Client.Enumerations;

namespace Bridge.AspNetCore.SignalR.Client
{
    /// <summary>
    /// Hub message model
    /// </summary>
    [External]
    [Namespace(false)]
    [ObjectLiteral]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCamelCase)]
    public class HubMessage
    {
        #region Public Methods

        /// <summary>
        /// The type of message
        /// </summary>
        public MessageType Type { get; set; }

        /// <summary>
        /// The ID of the invocation
        /// </summary>
        public string InvocationId { get; set; }

        #endregion
    }
}
