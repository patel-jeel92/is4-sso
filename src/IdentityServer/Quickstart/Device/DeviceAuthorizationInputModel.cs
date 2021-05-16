//-----------------------------------------------------------------------
// <copyright file="DeviceAuthorizationInputModel.cs" company="Patel">
//     See the [assembly: AssemblyCopyright(..)] marking attribute linked in to this file's associated project for copyright � information.
// </copyright>
//-----------------------------------------------------------------------
namespace IdentityServer.Device
{
    /// <summary>
    /// Device authorization input model.
    /// </summary>
    /// <seealso cref="IdentityServer.ConsentInputModel" />
    public class DeviceAuthorizationInputModel : ConsentInputModel
    {
        /// <summary>
        /// Gets or sets the user code.
        /// </summary>
        /// <value>
        /// The user code.
        /// </value>
        public string UserCode { get; set; }
    }
}