using Bridge;

namespace signalR
{
    /// <summary>
    /// Logger that is used when the logger or log level is null
    /// </summary>
    [External]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCamelCase)]
    public class NullLogger 
    {
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