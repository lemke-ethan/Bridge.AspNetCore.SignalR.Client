namespace Bridge.AspNetCore.SignalR.Client.Interfaces
{
    /// <summary>
    /// Hub connection options
    /// </summary>
    [External]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCamelCase)]
    public interface IHubConnectionOptions : IHttpConnectionOptions
    {
        #region Public Properties

        /// <summary>
        /// The hub's protocol
        /// </summary>
        IHubProtocol Protocol { get; set; }

        #endregion
    }
}
