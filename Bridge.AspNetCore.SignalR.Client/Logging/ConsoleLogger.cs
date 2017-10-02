namespace Bridge.AspNetCore.SignalR.Client
{
    /// <summary>
    /// Logger that is used when one is not provided
    /// </summary>
    [External]
    [Namespace("signalR")]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCamelCase)]
    public class ConsoleLogger 
    {
        #region Constructor

        /// <summary>
        /// Creates a <see cref="ConsoleLogger"/> with a minimum <see cref="LogLevel"/>
        /// </summary>
        /// <param name="minimumLogLevel">The minimum <see cref="LogLevel"/></param>
        public ConsoleLogger(LogLevel minimumLogLevel) { }

        #endregion

        #region Public Methods

        /// <summary>
        /// Log the message
        /// </summary>
        /// <param name="level">The level of logging</param>
        /// <param name="message">The message to be logged</param>
        public void Log(LogLevel level, string message) { }

        #endregion
    }
}