namespace Bridge.AspNetCore.SignalR.Client.Enumerations
{
    /// <summary>
    /// The type of transfer mode
    /// </summary>
    [External]
    [Namespace("signalR")]
    public enum TransferMode
    {
        /// <summary>
        /// Text transfer mode
        /// </summary>
        Text = 1,

        /// <summary>
        /// Binary transfer mode
        /// </summary>
        Binary
    }
}
