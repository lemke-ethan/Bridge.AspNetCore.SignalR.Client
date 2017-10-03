using System;

namespace Bridge.AspNetCore.SignalR.Client.Threading
{
    /// <summary>
    /// Represents the completion of an asynchronous operation
    /// </summary>
    /// <remarks>
    /// Modeled off of the ES6 Promise<T> interface.
    /// https://tc39.github.io/ecma262/#sec-properties-of-the-promise-prototype-object
    /// </remarks>
    [External]
    [Namespace(false)]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCamelCase)]
    public interface IPromise
    {
        #region Public Methods

        /// <summary>
        /// Attaches callbacks for the resolution and/or rejection of the Promise
        /// </summary>
        /// <param name="onfulfilled">The callback to execute when the Promise is resolved</param>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromise Then(Action onfulfilled = null, Action<object> onrejected = null);

        /// <summary>
        /// Attaches callbacks for the resolution and/or rejection of the Promise
        /// </summary>
        /// <param name="onfulfilled">The callback to execute when the Promise is resolved</param>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromise Then(Func<IPromiseLike> onfulfilled = null, Action<object> onrejected = null);

        /// <summary>
        /// Attaches callbacks for the resolution and/or rejection of the Promise
        /// </summary>
        /// <param name="onfulfilled">The callback to execute when the Promise is resolved</param>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromise Then(Action onfulfilled = null, Func<object, IPromiseLike> onrejected = null);

        /// <summary>
        /// Attaches callbacks for the resolution and/or rejection of the Promise
        /// </summary>
        /// <param name="onfulfilled">The callback to execute when the Promise is resolved</param>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromise Then(Func<IPromiseLike> onfulfilled = null, Func<object, IPromiseLike> onrejected = null);

        /// <summary>
        /// Attaches a callback for only the rejection of the Promise
        /// </summary>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromise Catch(Action<object> onrejected = null);

        /// <summary>
        /// Attaches a callback for only the rejection of the Promise
        /// </summary>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromise Catch(Func<object, IPromiseLike> onrejected = null);

        #endregion
    }

    /// <summary>
    /// Represents the completion of an asynchronous operation
    /// </summary>
    /// <typeparam name="T">The promised type</typeparam>
    /// <remarks>
    /// Modeled off of the ES6 Promise<T> interface.
    /// https://tc39.github.io/ecma262/#sec-properties-of-the-promise-prototype-object
    /// </remarks>
    [External]
    [Namespace(false)]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCamelCase)]
    public interface IPromise<T>
    {
        #region Public Methods

        /// <summary>
        /// Attaches callbacks for the resolution and/or rejection of the Promise
        /// </summary>
        /// <param name="onfulfilled">The callback to execute when the Promise is resolved</param>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromise<T> Then(Func<T, T> onfulfilled = null, Action<object> onrejected = null);

        /// <summary>
        /// Attaches callbacks for the resolution and/or rejection of the Promise
        /// </summary>
        /// <param name="onfulfilled">The callback to execute when the Promise is resolved</param>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromise<T> Then(Func<T, IPromiseLike<T>> onfulfilled = null, Action<object> onrejected = null);

        /// <summary>
        /// Attaches callbacks for the resolution and/or rejection of the Promise
        /// </summary>
        /// <param name="onfulfilled">The callback to execute when the Promise is resolved</param>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromise<T> Then(Func<T, T> onfulfilled = null, Func<object, IPromiseLike> onrejected = null);

        /// <summary>
        /// Attaches callbacks for the resolution and/or rejection of the Promise
        /// </summary>
        /// <param name="onfulfilled">The callback to execute when the Promise is resolved</param>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromise<T> Then(Func<T, IPromiseLike<T>> onfulfilled = null, Func<object, IPromiseLike> onrejected = null);

        /// <summary>
        /// Attaches a callback for only the rejection of the Promise
        /// </summary>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromise Catch(Action<object> onrejected = null);

        /// <summary>
        /// Attaches a callback for only the rejection of the Promise
        /// </summary>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromise Catch(Func<object, IPromiseLike> onrejected = null);

        #endregion
    }
}
