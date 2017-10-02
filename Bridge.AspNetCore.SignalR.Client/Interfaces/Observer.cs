namespace Bridge.AspNetCore.SignalR.Client.Interfaces
{
    /// <summary>
    /// Observer
    /// </summary>
    /// <typeparam name="T">The type being observed</typeparam>
    [External]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCamelCase)]
    public interface Observer<T>
    {
        #region Public Properties

        /// <summary>
        /// Indicates if the observer is closed
        /// </summary>
        bool? Closed { get; set; }

        #endregion

        #region Public Methods

        /// <summary>
        /// Set the next value
        /// </summary>
        /// <param name="value">The next value to observe</param>
        void Next(T value);

        /// <summary>
        /// Set the error
        /// </summary>
        /// <param name="any">The error data</param>
        void Error(object any);

        /// <summary>
        /// Close the observer
        /// </summary>
        void Complete();

        #endregion
    }
}
