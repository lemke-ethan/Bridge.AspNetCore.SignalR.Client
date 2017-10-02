namespace Bridge.AspNetCore.SignalR.Client.Enumerations
{
    /// <summary>
    /// The type of message
    /// </summary>
    [External]
    public enum MessageType
    {
        /// <summary>
        /// Invocation message
        /// </summary>
        Invocation = 1,

        /// <summary>
        /// Result message
        /// </summary>
        Result,

        /// <summary>
        /// Completion message
        /// </summary>
        Completion
    }
}
