namespace Bridge.AspNetCore.SignalR.Client
{
    /// <summary>
    /// HTTP connection options
    /// </summary>
    [External]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCamelCase)]
    public interface IHttpConnectionOptions
    {
        #region Public Properties

        /// <summary>
        /// The HTTP client
        /// </summary>
        IHttpClient HttpClient { get; set; }

        /// <summary>
        /// The type of transport
        /// </summary>
        [Name("transport")]
        TransportType? TransportType { get; set; }

        #endregion
    }
}
