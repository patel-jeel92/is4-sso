//-----------------------------------------------------------------------
// <copyright file="ProcessConsentResult.cs" company="Patel">
//     See the [assembly: AssemblyCopyright(..)] marking attribute linked in to this file's associated project for copyright � information.
// </copyright>
//-----------------------------------------------------------------------

namespace IdentityServer
{
    /// <summary>
    /// Process consent result class.
    /// </summary>
    public class ProcessConsentResult
    {
        /// <summary>
        /// Gets or sets the client identifier.
        /// </summary>
        /// <value>
        /// The client identifier.
        /// </value>
        public string ClientId { get; set; }

        /// <summary>
        /// Gets a value indicating whether this instance has validation error.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has validation error; otherwise, <c>false</c>.
        /// </value>
        public bool HasValidationError => this.ValidationError != null;

        /// <summary>
        /// Gets a value indicating whether this instance is redirect.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is redirect; otherwise, <c>false</c>.
        /// </value>
        public bool IsRedirect => this.RedirectUri != null;

        /// <summary>
        /// Gets or sets the redirect URI.
        /// </summary>
        /// <value>
        /// The redirect URI.
        /// </value>
        public string RedirectUri { get; set; }

        /// <summary>
        /// Gets a value indicating whether [show view].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show view]; otherwise, <c>false</c>.
        /// </value>
        public bool ShowView => this.ViewModel != null;

        /// <summary>
        /// Gets or sets the validation error.
        /// </summary>
        /// <value>
        /// The validation error.
        /// </value>
        public string ValidationError { get; set; }

        /// <summary>
        /// Gets or sets the view model.
        /// </summary>
        /// <value>
        /// The view model.
        /// </value>
        public ConsentViewModel ViewModel { get; set; }
    }
}