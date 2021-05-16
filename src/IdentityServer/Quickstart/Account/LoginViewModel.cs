//-----------------------------------------------------------------------
// <copyright file="LoginViewModel.cs" company="Patel">
//     See the [assembly: AssemblyCopyright(..)] marking attribute linked in to this file's associated project for copyright � information.
// </copyright>
//-----------------------------------------------------------------------
namespace IdentityServer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Login view model domain class.
    /// </summary>
    /// <seealso cref="IdentityServer.LoginInputModel" />
    public class LoginViewModel : LoginInputModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether [allow remember login].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [allow remember login]; otherwise, <c>false</c>.
        /// </value>
        public bool AllowRememberLogin { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether [enable local login].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [enable local login]; otherwise, <c>false</c>.
        /// </value>
        public bool EnableLocalLogin { get; set; } = true;

        /// <summary>
        /// Gets the external login scheme.
        /// </summary>
        /// <value>
        /// The external login scheme.
        /// </value>
        public string ExternalLoginScheme => this.IsExternalLoginOnly ? this.ExternalProviders?.SingleOrDefault()?.AuthenticationScheme : null;

        /// <summary>
        /// Gets or sets the external providers.
        /// </summary>
        /// <value>
        /// The external providers.
        /// </value>
        public IEnumerable<ExternalProvider> ExternalProviders { get; set; } = Enumerable.Empty<ExternalProvider>();

        /// <summary>
        /// Gets a value indicating whether this instance is external login only.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is external login only; otherwise, <c>false</c>.
        /// </value>
        public bool IsExternalLoginOnly => this.EnableLocalLogin == false && this.ExternalProviders?.Count() == 1;

        /// <summary>
        /// Gets the visible external providers.
        /// </summary>
        /// <value>
        /// The visible external providers.
        /// </value>
        public IEnumerable<ExternalProvider> VisibleExternalProviders => this.ExternalProviders.Where(x => !String.IsNullOrWhiteSpace(x.DisplayName));
    }
}