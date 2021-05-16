//-----------------------------------------------------------------------
// <copyright file="DeviceController.cs" company="Patel">
//     See the [assembly: AssemblyCopyright(..)] marking attribute linked in to this file's associated project for copyright � information.
// </copyright>
//-----------------------------------------------------------------------

namespace IdentityServer.Device
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using IdentityServer4.Events;
    using IdentityServer4.Extensions;
    using IdentityServer4.Models;
    using IdentityServer4.Services;
    using IdentityServer4.Stores;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    /// <summary>
    ///
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    [Authorize]
    [SecurityHeaders]
    public class DeviceController : Controller
    {
        /// <summary>
        /// The client store
        /// </summary>
        private readonly IClientStore _clientStore;

        /// <summary>
        /// The events
        /// </summary>
        private readonly IEventService _events;

        /// <summary>
        /// The interaction
        /// </summary>
        private readonly IDeviceFlowInteractionService _interaction;

        /// <summary>
        /// The logger
        /// </summary>
        private readonly ILogger<DeviceController> _logger;

        /// <summary>
        /// The resource store
        /// </summary>
        private readonly IResourceStore _resourceStore;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceController"/> class.
        /// </summary>
        /// <param name="interaction">The interaction.</param>
        /// <param name="clientStore">The client store.</param>
        /// <param name="resourceStore">The resource store.</param>
        /// <param name="eventService">The event service.</param>
        /// <param name="logger">The logger.</param>
        public DeviceController(
            IDeviceFlowInteractionService interaction,
            IClientStore clientStore,
            IResourceStore resourceStore,
            IEventService eventService,
            ILogger<DeviceController> logger)
        {
            this._interaction = interaction;
            this._clientStore = clientStore;
            this._resourceStore = resourceStore;
            this._events = eventService;
            this._logger = logger;
        }

        /// <summary>
        /// Callbacks the specified model.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">model</exception>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Callback(DeviceAuthorizationInputModel model)
        {
            if (model == null) throw new ArgumentNullException(nameof(model));

            var result = await this.ProcessConsent(model);
            if (result.HasValidationError) return this.View("Error");

            return this.View("Success");
        }

        /// <summary>
        /// Creates the scope view model.
        /// </summary>
        /// <param name="scope">The scope.</param>
        /// <param name="check">if set to <c>true</c> [check].</param>
        /// <returns></returns>
        public ScopeViewModel CreateScopeViewModel(Scope scope, bool check)
        {
            return new ScopeViewModel
            {
                Name = scope.Name,
                DisplayName = scope.DisplayName,
                Description = scope.Description,
                Emphasize = scope.Emphasize,
                Required = scope.Required,
                Checked = check || scope.Required
            };
        }

        /// <summary>
        /// Indexes the specified user code.
        /// </summary>
        /// <param name="userCode">The user code.</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Index([FromQuery(Name = "user_code")] string userCode)
        {
            if (string.IsNullOrWhiteSpace(userCode)) return this.View("UserCodeCapture");

            var vm = await this.BuildViewModelAsync(userCode);
            if (vm == null) return this.View("Error");

            vm.ConfirmUserCode = true;
            return this.View("UserCodeConfirmation", vm);
        }

        /// <summary>
        /// Users the code capture.
        /// </summary>
        /// <param name="userCode">The user code.</param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UserCodeCapture(string userCode)
        {
            var vm = await this.BuildViewModelAsync(userCode);
            if (vm == null) return this.View("Error");

            return this.View("UserCodeConfirmation", vm);
        }

        /// <summary>
        /// Builds the view model asynchronous.
        /// </summary>
        /// <param name="userCode">The user code.</param>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        private async Task<DeviceAuthorizationViewModel> BuildViewModelAsync(string userCode, DeviceAuthorizationInputModel model = null)
        {
            var request = await this._interaction.GetAuthorizationContextAsync(userCode);
            if (request != null)
            {
                var client = await this._clientStore.FindEnabledClientByIdAsync(request.ClientId);
                if (client != null)
                {
                    var resources = await this._resourceStore.FindEnabledResourcesByScopeAsync(request.ScopesRequested);
                    if (resources != null && (resources.IdentityResources.Any() || resources.ApiResources.Any()))
                    {
                        return this.CreateConsentViewModel(userCode, model, client, resources);
                    }
                    else
                    {
                        this._logger.LogError("No scopes matching: {0}", request.ScopesRequested.Aggregate((x, y) => x + ", " + y));
                    }
                }
                else
                {
                    this._logger.LogError("Invalid client id: {0}", request.ClientId);
                }
            }

            return null;
        }

        /// <summary>
        /// Creates the consent view model.
        /// </summary>
        /// <param name="userCode">The user code.</param>
        /// <param name="model">The model.</param>
        /// <param name="client">The client.</param>
        /// <param name="resources">The resources.</param>
        /// <returns></returns>
        private DeviceAuthorizationViewModel CreateConsentViewModel(string userCode, DeviceAuthorizationInputModel model, Client client, Resources resources)
        {
            var vm = new DeviceAuthorizationViewModel
            {
                UserCode = userCode,

                RememberConsent = model?.RememberConsent ?? true,
                ScopesConsented = model?.ScopesConsented ?? Enumerable.Empty<string>(),

                ClientName = client.ClientName ?? client.ClientId,
                ClientUrl = client.ClientUri,
                ClientLogoUrl = client.LogoUri,
                AllowRememberConsent = client.AllowRememberConsent
            };

            vm.IdentityScopes = resources.IdentityResources.Select(x => this.CreateScopeViewModel(x, vm.ScopesConsented.Contains(x.Name) || model == null)).ToArray();
            vm.ResourceScopes = resources.ApiResources.SelectMany(x => x.Scopes).Select(x => this.CreateScopeViewModel(x, vm.ScopesConsented.Contains(x.Name) || model == null)).ToArray();
            if (ConsentOptions.EnableOfflineAccess && resources.OfflineAccess)
            {
                vm.ResourceScopes = vm.ResourceScopes.Union(new[]
                {
                    this.GetOfflineAccessScope(vm.ScopesConsented.Contains(IdentityServer4.IdentityServerConstants.StandardScopes.OfflineAccess) || model == null)
                });
            }

            return vm;
        }

        /// <summary>
        /// Creates the scope view model.
        /// </summary>
        /// <param name="identity">The identity.</param>
        /// <param name="check">if set to <c>true</c> [check].</param>
        /// <returns></returns>
        private ScopeViewModel CreateScopeViewModel(IdentityResource identity, bool check)
        {
            return new ScopeViewModel
            {
                Name = identity.Name,
                DisplayName = identity.DisplayName,
                Description = identity.Description,
                Emphasize = identity.Emphasize,
                Required = identity.Required,
                Checked = check || identity.Required
            };
        }

        /// <summary>
        /// Gets the offline access scope.
        /// </summary>
        /// <param name="check">if set to <c>true</c> [check].</param>
        /// <returns></returns>
        private ScopeViewModel GetOfflineAccessScope(bool check)
        {
            return new ScopeViewModel
            {
                Name = IdentityServer4.IdentityServerConstants.StandardScopes.OfflineAccess,
                DisplayName = ConsentOptions.OfflineAccessDisplayName,
                Description = ConsentOptions.OfflineAccessDescription,
                Emphasize = true,
                Checked = check
            };
        }

        /// <summary>
        /// Processes the consent.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <returns></returns>
        private async Task<ProcessConsentResult> ProcessConsent(DeviceAuthorizationInputModel model)
        {
            var result = new ProcessConsentResult();

            var request = await this._interaction.GetAuthorizationContextAsync(model.UserCode);
            if (request == null) return result;

            ConsentResponse grantedConsent = null;

            // user clicked 'no' - send back the standard 'access_denied' response
            if (model.Button == "no")
            {
                grantedConsent = ConsentResponse.Denied;

                // emit event
                await this._events.RaiseAsync(new ConsentDeniedEvent(this.User.GetSubjectId(), request.ClientId, request.ScopesRequested));
            }
            // user clicked 'yes' - validate the data
            else if (model.Button == "yes")
            {
                // if the user consented to some scope, build the response model
                if (model.ScopesConsented != null && model.ScopesConsented.Any())
                {
                    var scopes = model.ScopesConsented;
                    if (ConsentOptions.EnableOfflineAccess == false)
                    {
                        scopes = scopes.Where(x => x != IdentityServer4.IdentityServerConstants.StandardScopes.OfflineAccess);
                    }

                    grantedConsent = new ConsentResponse
                    {
                        RememberConsent = model.RememberConsent,
                        ScopesConsented = scopes.ToArray()
                    };

                    // emit event
                    await this._events.RaiseAsync(new ConsentGrantedEvent(this.User.GetSubjectId(), request.ClientId, request.ScopesRequested, grantedConsent.ScopesConsented, grantedConsent.RememberConsent));
                }
                else
                {
                    result.ValidationError = ConsentOptions.MustChooseOneErrorMessage;
                }
            }
            else
            {
                result.ValidationError = ConsentOptions.InvalidSelectionErrorMessage;
            }

            if (grantedConsent != null)
            {
                // communicate outcome of consent back to identityserver
                await this._interaction.HandleRequestAsync(model.UserCode, grantedConsent);

                // indicate that's it ok to redirect back to authorization endpoint
                result.RedirectUri = model.ReturnUrl;
                result.ClientId = request.ClientId;
            }
            else
            {
                // we need to redisplay the consent UI
                result.ViewModel = await this.BuildViewModelAsync(model.UserCode, model);
            }

            return result;
        }
    }
}