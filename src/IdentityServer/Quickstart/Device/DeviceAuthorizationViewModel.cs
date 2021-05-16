//-----------------------------------------------------------------------
// <copyright file="DeviceAuthorizationViewModel.cs" company="Patel">
//     See the [assembly: AssemblyCopyright(..)] marking attribute linked in to this file's associated project for copyright � information.
// </copyright>
//-----------------------------------------------------------------------

namespace IdentityServer.Device
{
    /// <summary>
    /// Device authorization view model class.
    /// </summary>
    /// <seealso cref="IdentityServer.ConsentViewModel" />
    public class DeviceAuthorizationViewModel : ConsentViewModel
    {
        /// <summary>
        /// Gets or sets a value indicating whether [confirm user code].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [confirm user code]; otherwise, <c>false</c>.
        /// </value>
        public bool ConfirmUserCode { get; set; }

        /// <summary>
        /// Gets or sets the user code.
        /// </summary>
        /// <value>
        /// The user code.
        /// </value>
        public string UserCode { get; set; }
    }
}