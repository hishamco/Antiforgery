// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Antiforgery
{
    /// <summary>
    /// Provides access to the antiforgery system, which provides protection against
    /// Cross-site Request Forgery (XSRF, also called CSRF) attacks.
    /// </summary>
    public interface IAntiforgery
    {
        /// <summary>
        /// Generates an &lt;input type="hidden"&gt; element for an antiforgery token.
        /// </summary>
        /// <param name="httpContext">The <see cref="HttpContext"/> associated with the current request.</param>
        /// <returns>
        /// A <see cref="IHtmlContent"/> containing an &lt;input type="hidden"&gt; element. This element should be put
        /// inside a &lt;form&gt;.
        /// </returns>
        /// <remarks>
        /// This method has a side effect:
        /// A response cookie is set if there is no valid cookie associated with the request.
        /// </remarks>
        IHtmlContent GetHtml(HttpContext httpContext);

        /// <summary>
        /// Generates an <see cref="AntiforgeryTokenSet"/> for this request and stores the cookie token
        /// in the response.
        /// </summary>
        /// <param name="httpContext">The <see cref="HttpContext"/> associated with the current request.</param>
        /// <returns>An <see cref="AntiforgeryTokenSet" /> with tokens for the response.</returns>
        /// <remarks>
        /// This method has a side effect:
        /// A response cookie is set if there is no valid cookie associated with the request.
        /// </remarks>
        AntiforgeryTokenSet GetAndStoreTokens(HttpContext httpContext);

        /// <summary>
        /// Generates an <see cref="AntiforgeryTokenSet"/> for this request.
        /// </summary>
        /// <param name="httpContext">The <see cref="HttpContext"/> associated with the current request.</param>
        /// <remarks>
        /// Unlike <see cref="GetAndStoreTokens(HttpContext)"/>, this method has no side effect. The caller
        /// is responsible for setting the response cookie and injecting the returned
        /// form token as appropriate.
        /// </remarks>
        AntiforgeryTokenSet GetTokens(HttpContext httpContext);

        /// <summary>
        /// Asynchronously returns a value indicating whether the request contains a valid antiforgery token.
        /// </summary>
        /// <param name="httpContext">The <see cref="HttpContext"/> associated with the current request.</param>
        /// <returns>
        /// A <see cref="Task{bool}"/> that, when completed, returns <c>true</c> if the request contains a
        /// valid antiforgery token, otherwise returns <c>false</c>.
        /// </returns>
        Task<bool> IsRequestValidAsync(HttpContext httpContext);

        /// <summary>
        /// Validates an antiforgery token that was supplied as part of the request.
        /// </summary>
        /// <param name="httpContext">The <see cref="HttpContext"/> associated with the current request.</param>
        /// <exception cref="AntiforgeryValidationException">
        /// Thrown when the request does not include a valid antiforgery token.
        /// </exception>
        Task ValidateRequestAsync(HttpContext httpContext);

        /// <summary>
        /// Validates an <see cref="AntiforgeryTokenSet"/> for the current request.
        /// </summary>
        /// <param name="httpContext">The <see cref="HttpContext"/> associated with the current request.</param>
        /// <param name="antiforgeryTokenSet">
        /// The <see cref="AntiforgeryTokenSet"/> (cookie and request token) for this request.
        /// </param>
        void ValidateTokens(HttpContext httpContext, AntiforgeryTokenSet antiforgeryTokenSet);

        /// <summary>
        /// Generates and stores an antiforgery cookie token if one is not available or not valid.
        /// </summary>
        /// <param name="httpContext">The <see cref="HttpContext"/> associated with the current request.</param>
        void SetCookieTokenAndHeader(HttpContext httpContext);
    }
}
