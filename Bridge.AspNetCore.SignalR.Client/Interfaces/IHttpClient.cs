using Bridge.AspNetCore.SignalR.Client.Threading;
using System.Collections.Generic;

namespace Bridge.AspNetCore.SignalR.Client
{
    [External]
    [Convention(Target = ConventionTarget.Member, Notation = Notation.LowerCamelCase)]
    public interface IHttpClient
    {
        #region Public Methods

        /// <summary>
        /// Performs a HTTP GET request
        /// </summary>
        /// <param name="url">The target URL</param>
        /// <param name="headers">Headers to be added to the request</param>
        /// <returns>The response</returns>
        IPromise<string> Get(string url, Dictionary<string, string> headers = null);

        /// <summary>
        /// Performs a HTTP OPTIONS request
        /// </summary>
        /// <param name="url">The target URL</param>
        /// <param name="headers">Headers to be added to the request</param>
        /// <returns>The response</returns>
        IPromise<string> Options(string url, Dictionary<string, string> headers = null);

        /// <summary>
        /// Performs a HTTP POST request
        /// </summary>
        /// <param name="url">The target URL</param>
        /// <param name="headers">Headers to be added to the request</param>
        /// <returns>The response</returns>
        IPromise<string> Post(string url, Dictionary<string, string> headers = null);

        #endregion
    }
}
