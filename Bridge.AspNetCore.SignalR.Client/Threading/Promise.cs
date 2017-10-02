using System;
using System.Threading.Tasks;

namespace Bridge.AspNetCore.SignalR.Client.Threading
{
    /// <summary>
    /// A promise of value from the completion of an operation
    /// </summary>
    /// <typeparam name="TResult">The type of the expected result</typeparam>
    [External]
    [Namespace(false)]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCamelCase)]
    public class Promise<TResult> : IPromise
    {
        #region IPromise Implementation

        /// <summary>
        /// Adds a fulfilledHandler, errorHandler to be called for completion of a promise.
        /// </summary>
        /// <param name="fulfilledHandler">The fulfilledHandler is called when the promise is fulfilled.</param>
        /// <param name="errorHandler">The errorHandler is called when a promise fails.</param>
        /// <param name="progressHandler">The progressHandler is called when the promise has made progress.</param>
        public void Then(Delegate fulfilledHandler, Delegate errorHandler = null, Delegate progressHandler = null) { }
     
        #endregion
    }

    /// <summary>
    /// A promise of value from the completion of an operation
    /// </summary>
    [External]
    [Namespace(false)]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCamelCase)]
    public class Promise : IPromise
    {
        #region IPromise Implementation

        /// <summary>
        /// Adds a fulfilledHandler, errorHandler to be called for completion of a promise.
        /// </summary>
        /// <param name="fulfilledHandler">The fulfilledHandler is called when the promise is fulfilled.</param>
        /// <param name="errorHandler">The errorHandler is called when a promise fails.</param>
        /// <param name="progressHandler">The progressHandler is called when the promise has made progress.</param>
        public void Then(Delegate fulfilledHandler, Delegate errorHandler = null, Delegate progressHandler = null) { }

        #endregion
    }
}
