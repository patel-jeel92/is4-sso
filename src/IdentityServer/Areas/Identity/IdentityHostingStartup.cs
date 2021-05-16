//-----------------------------------------------------------------------
// <copyright file="FileName.cs" company="Patel">
//     See the [assembly: AssemblyCopyright(..)] marking attribute linked in to this file's associated project for copyright © information.
// </copyright>
//-----------------------------------------------------------------------

using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(IdentityServer.Areas.Identity.IdentityHostingStartup))]

namespace IdentityServer.Areas.Identity
{
    using Microsoft.AspNetCore.Hosting;

    /// <summary>
    /// Startup class for hosting.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Hosting.IHostingStartup" />
    public class IdentityHostingStartup : IHostingStartup
    {
        /// <summary>
        /// Configure the <see cref="T:Microsoft.AspNetCore.Hosting.IWebHostBuilder" />.
        /// </summary>
        /// <param name="builder"></param>
        /// <remarks>
        /// Configure is intended to be called before user code, allowing a user to overwrite any changes made.
        /// </remarks>
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}