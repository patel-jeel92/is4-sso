//-----------------------------------------------------------------------
// <copyright file="ConsentViewModel.cs" company="Patel">
//     See the [assembly: AssemblyCopyright(..)] marking attribute linked in to this file's associated project for copyright © information.
// </copyright>
//-----------------------------------------------------------------------

namespace IdentityServer
{
    using System.Collections.Generic;

    /// <summary>
    /// Consent view model class.
    /// </summary>
    /// <seealso cref="IdentityServer.ConsentInputModel" />
    public class ConsentViewModel : ConsentInputModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether [allow remember consent].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow remember consent]; otherwise, <c>false</c>.
        /// </value>
        public bool AllowRememberConsent { get; set; }

        /// <summary>
        /// Gets or sets the client logo URL.
        /// </summary>
        /// <value>
        /// The client logo URL.
        /// </value>
        public string ClientLogoUrl { get; set; }

        /// <summary>
        /// Gets or sets the name of the client.
        /// </summary>
        /// <value>
        /// The name of the client.
        /// </value>
        public string ClientName { get; set; }

        /// <summary>
        /// Gets or sets the client URL.
        /// </summary>
        /// <value>
        /// The client URL.
        /// </value>
        public string ClientUrl { get; set; }

        /// <summary>
        /// Gets or sets the identity scopes.
        /// </summary>
        /// <value>
        /// The identity scopes.
        /// </value>
        public IEnumerable<ScopeViewModel> IdentityScopes { get; set; }

        /// <summary>
        /// Gets or sets the resource scopes.
        /// </summary>
        /// <value>
        /// The resource scopes.
        /// </value>
        public IEnumerable<ScopeViewModel> ResourceScopes { get; set; }
    }
}