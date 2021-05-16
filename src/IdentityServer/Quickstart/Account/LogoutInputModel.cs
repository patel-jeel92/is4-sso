//-----------------------------------------------------------------------
// <copyright file="LogoutInputModel.cs" company="Patel">
//     See the [assembly: AssemblyCopyright(..)] marking attribute linked in to this file's associated project for copyright © information.
// </copyright>
//-----------------------------------------------------------------------
namespace IdentityServer
{
    /// <summary>
    /// Login input domain class.
    /// </summary>
    public class LogoutInputModel
    {
        /// <summary>
        /// Gets or sets the logout identifier.
        /// </summary>
        /// <value>
        /// The logout identifier.
        /// </value>
        public string LogoutId { get; set; }
    }
}