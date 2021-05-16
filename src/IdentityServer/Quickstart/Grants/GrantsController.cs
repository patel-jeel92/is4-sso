//-----------------------------------------------------------------------
// <copyright file="GrantsController.cs" company="Patel">
//     See the [assembly: AssemblyCopyright(..)] marking attribute linked in to this file's associated project for copyright � information.
// </copyright>
//-----------------------------------------------------------------------
namespace IdentityServer
{
    using IdentityServer4.Services;
    using IdentityServer4.Stores;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using IdentityServer4.Events;
    using IdentityServer4.Extensions;

    /// <summary>
    /// This sample controller allows a user to revoke grants given to clients
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    [SecurityHeaders]
    [Authorize]
    public class GrantsController : Controller
    {
        /// <summary>
        /// The clients
        /// </summary>
        private readonly IClientStore _clients;

        /// <summary>
        /// The events
        /// </summary>
        private readonly IEventService _events;

        /// <summary>
        /// The interaction
        /// </summary>
        private readonly IIdentityServerInteractionService _interaction;

        /// <summary>
        /// The resources
        /// </summary>
        private readonly IResourceStore _resources;

        /// <summary>
        /// Initializes a new instance of the <see cref="GrantsController"/> class.
        /// </summary>
        /// <param name="interaction">The interaction.</param>
        /// <param name="clients">The clients.</param>
        /// <param name="resources">The resources.</param>
        /// <param name="events">The events.</param>
        public GrantsController(IIdentityServerInteractionService interaction,
            IClientStore clients,
            IResourceStore resources,
            IEventService events)
        {
            this._interaction = interaction;
            this._clients = clients;
            this._resources = resources;
            this._events = events;
        }

        /// <summary>
        /// Show list of grants
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return this.View("Index", await this.BuildViewModelAsync());
        }

        /// <summary>
        /// Handle postback to revoke a client
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Revoke(string clientId)
        {
            await this._interaction.RevokeUserConsentAsync(clientId);
            await this._events.RaiseAsync(new GrantsRevokedEvent(this.User.GetSubjectId(), clientId));

            return this.RedirectToAction("Index");
        }

        /// <summary>
        /// Builds the view model asynchronous.
        /// </summary>
        /// <returns></returns>
        private async Task<GrantsViewModel> BuildViewModelAsync()
        {
            var grants = await this._interaction.GetAllUserConsentsAsync();

            var list = new List<GrantViewModel>();
            foreach (var grant in grants)
            {
                var client = await this._clients.FindClientByIdAsync(grant.ClientId);
                if (client != null)
                {
                    var resources = await this._resources.FindResourcesByScopeAsync(grant.Scopes);

                    var item = new GrantViewModel()
                    {
                        ClientId = client.ClientId,
                        ClientName = client.ClientName ?? client.ClientId,
                        ClientLogoUrl = client.LogoUri,
                        ClientUrl = client.ClientUri,
                        Created = grant.CreationTime,
                        Expires = grant.Expiration,
                        IdentityGrantNames = resources.IdentityResources.Select(x => x.DisplayName ?? x.Name).ToArray(),
                        ApiGrantNames = resources.ApiResources.Select(x => x.DisplayName ?? x.Name).ToArray()
                    };

                    list.Add(item);
                }
            }

            return new GrantsViewModel
            {
                Grants = list
            };
        }
    }
}