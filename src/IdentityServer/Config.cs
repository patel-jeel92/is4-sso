//-----------------------------------------------------------------------
// <copyright file="Config.cs" company="Patel">
//     See the [assembly: AssemblyCopyright(..)] marking attribute linked in to this file's associated project for copyright © information.
// </copyright>
//-----------------------------------------------------------------------
namespace IdentityServer
{
    using IdentityServer4.Models;
    using System.Collections.Generic;

    /// <summary>
    /// Config class.
    /// </summary>
    public static class Config
    {
        /// <summary>
        /// Gets the apis.
        /// </summary>
        /// <value>
        /// The apis.
        /// </value>
        public static IEnumerable<ApiResource> Apis =>
            new ApiResource[]
            { };

        /// <summary>
        /// Gets the clients.
        /// </summary>
        /// <value>
        /// The clients.
        /// </value>
        public static IEnumerable<Client> Clients =>
            new Client[]
            { };

        /// <summary>
        /// Gets the ids.
        /// </summary>
        /// <value>
        /// The ids.
        /// </value>
        public static IEnumerable<IdentityResource> Ids =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId()
            };
    }
}