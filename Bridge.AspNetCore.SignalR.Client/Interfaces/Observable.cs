namespace Bridge.AspNetCore.SignalR.Client.Interfaces
{
    /// <summary>
    /// Adds observable capability to type <see cref="T"/>
    /// </summary>
    /// <typeparam name="T">The type that will be observed</typeparam>
    [External]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCamelCase)]
    public interface Observable<T>
    {
        #region Public Methods

        /// <summary>
        /// Subscribes to observable events of the type <see cref="T"/>
        /// </summary>
        /// <param name="observer"><see cref="T"/>'s observer</param>
        void Subscribe(Observer<T> observer);

        #endregion
    }
}
