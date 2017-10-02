namespace Bridge.AspNetCore.SignalR.Client
{
    /// <summary>
    /// The level of logging
    /// </summary>
    [External]
    [Namespace("signalR")]
    public enum LogLevel
    {
        /// <summary>
        /// Log trace log requests 
        /// </summary>
        Trace,
        
        /// <summary>
        /// Log informational log requests 
        /// </summary>
        Information,

        /// <summary>
        /// Log warning log requests
        /// </summary>
        Warning,

        /// <summary>
        /// Log error log requests
        /// </summary>
        Error,

        /// <summary>
        /// Do not log anything
        /// </summary>
        None
    }
}