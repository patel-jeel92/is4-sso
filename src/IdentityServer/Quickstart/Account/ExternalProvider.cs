//-----------------------------------------------------------------------
// <copyright file="ExternalProvider.cs" company="Patel">
//     See the [assembly: AssemblyCopyright(..)] marking attribute linked in to this file's associated project for copyright © information.
// </copyright>
//-----------------------------------------------------------------------
namespace IdentityServer
{
    /// <summary>
    /// External provider domain class.
    /// </summary>
    public class ExternalProvider
    {
        /// <summary>
        /// Gets or sets the authentication scheme.
        /// </summary>
        /// <value>
        /// The authentication scheme.
        /// </value>
        public string AuthenticationScheme { get; set; }

        /// <summary>
        /// Gets or sets the display name.
        /// </summary>
        /// <value>
        /// The display name.
        /// </value>
        public string DisplayName { get; set; }
    }
}