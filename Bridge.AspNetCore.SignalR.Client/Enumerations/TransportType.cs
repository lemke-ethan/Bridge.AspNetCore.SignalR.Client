namespace Bridge.AspNetCore.SignalR.Client
{
    /// <summary>
    /// The type of transport
    /// </summary>
    [External]
    [Namespace("signalR")]
    public enum TransportType
    {
        /// <summary>
        /// Web sockets transport
        /// </summary>
        WebSockets,

        /// <summary>
        /// Sever sent events transport
        /// </summary>
        ServerSentEvents,

        /// <summary>
        /// Long polling transport
        /// </summary>
        LongPolling
    }
}
