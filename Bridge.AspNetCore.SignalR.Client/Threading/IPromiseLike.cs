using System;

namespace Bridge.AspNetCore.SignalR.Client.Threading
{
    /// <summary>
    /// Represents the completion of an asynchronous operation
    /// </summary>
    [External]
    [Namespace(false)]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCamelCase)]
    public interface IPromiseLike
    {
        #region Public Methods

        /// <summary>
        /// Attaches callbacks for the resolution and/or rejection of the Promise
        /// </summary>
        /// <param name="onfulfilled">The callback to execute when the Promise is resolved</param>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromiseLike Then(Action onfulfilled = null, Action<object> onrejected = null);

        /// <summary>
        /// Attaches callbacks for the resolution and/or rejection of the Promise
        /// </summary>
        /// <param name="onfulfilled">The callback to execute when the Promise is resolved</param>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromiseLike Then(Func<IPromiseLike> onfulfilled = null, Action<object> onrejected = null);

        /// <summary>
        /// Attaches callbacks for the resolution and/or rejection of the Promise
        /// </summary>
        /// <param name="onfulfilled">The callback to execute when the Promise is resolved</param>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromiseLike Then(Action onfulfilled = null, Func<object, IPromiseLike> onrejected = null);

        /// <summary>
        /// Attaches callbacks for the resolution and/or rejection of the Promise
        /// </summary>
        /// <param name="onfulfilled">The callback to execute when the Promise is resolved</param>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromiseLike Then(Func<IPromiseLike> onfulfilled = null, Func<object, IPromiseLike> onrejected = null);

        #endregion
    }

    /// <summary>
    /// Represents the completion of an asynchronous operation
    /// </summary>
    /// <typeparam name="T"></typeparam>
    [External]
    [Namespace(false)]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCamelCase)]
    public interface IPromiseLike<T>
    {
        #region Public Methods

        /// <summary>
        /// Attaches callbacks for the resolution and/or rejection of the Promise
        /// </summary>
        /// <param name="onfulfilled">The callback to execute when the Promise is resolved</param>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromiseLike<T> Then(Func<T, T> onfulfilled = null, Action<object> onrejected = null);

        /// <summary>
        /// Attaches callbacks for the resolution and/or rejection of the Promise
        /// </summary>
        /// <param name="onfulfilled">The callback to execute when the Promise is resolved</param>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromiseLike<T> Then(Func<T, IPromiseLike<T>> onfulfilled = null, Action<object> onrejected = null);

        /// <summary>
        /// Attaches callbacks for the resolution and/or rejection of the Promise
        /// </summary>
        /// <param name="onfulfilled">The callback to execute when the Promise is resolved</param>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromiseLike<T> Then(Func<T, T> onfulfilled = null, Func<object, IPromiseLike> onrejected = null);

        /// <summary>
        /// Attaches callbacks for the resolution and/or rejection of the Promise
        /// </summary>
        /// <param name="onfulfilled">The callback to execute when the Promise is resolved</param>
        /// <param name="onrejected">The callback to execute when the Promise is rejected</param>
        IPromiseLike<T> Then(Func<T, IPromiseLike<T>> onfulfilled = null, Func<object, IPromiseLike> onrejected = null);

        #endregion  
    }
}
