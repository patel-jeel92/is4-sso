//-----------------------------------------------------------------------
// <copyright file="DiagnosticsViewModel.cs" company="Patel">
//     See the [assembly: AssemblyCopyright(..)] marking attribute linked in to this file's associated project for copyright � information.
// </copyright>
//-----------------------------------------------------------------------

namespace IdentityServer
{
    using IdentityModel;
    using Microsoft.AspNetCore.Authentication;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Diagnostics view model class.
    /// </summary>
    public class DiagnosticsViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagnosticsViewModel"/> class.
        /// </summary>
        /// <param name="result">The result.</param>
        public DiagnosticsViewModel(AuthenticateResult result)
        {
            this.AuthenticateResult = result;

            if (result.Properties.Items.ContainsKey("client_list"))
            {
                var encoded = result.Properties.Items["client_list"];
                var bytes = Base64Url.Decode(encoded);
                var value = Encoding.UTF8.GetString(bytes);

                this.Clients = JsonConvert.DeserializeObject<string[]>(value);
            }
        }

        /// <summary>
        /// Gets the authenticate result.
        /// </summary>
        /// <value>
        /// The authenticate result.
        /// </value>
        public AuthenticateResult AuthenticateResult { get; }

        /// <summary>
        /// Gets the clients.
        /// </summary>
        /// <value>
        /// The clients.
        /// </value>
        public IEnumerable<string> Clients { get; } = new List<string>();
    }
}