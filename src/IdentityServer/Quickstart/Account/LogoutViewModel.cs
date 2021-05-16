//-----------------------------------------------------------------------
// <copyright file="LogoutViewModel.cs" company="Patel">
//     See the [assembly: AssemblyCopyright(..)] marking attribute linked in to this file's associated project for copyright � information.
// </copyright>
//-----------------------------------------------------------------------

namespace IdentityServer
{
    /// <summary>
    /// Log out view model domain class.
    /// </summary>
    /// <seealso cref="IdentityServer.LogoutInputModel" />
    public class LogoutViewModel : LogoutInputModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether [show logout prompt].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show logout prompt]; otherwise, <c>false</c>.
        /// </value>
        public bool ShowLogoutPrompt { get; set; } = true;
    }
}