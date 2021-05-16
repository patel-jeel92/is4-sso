//-----------------------------------------------------------------------
// <copyright file="HomeController.cs" company="Patel">
//     See the [assembly: AssemblyCopyright(..)] marking attribute linked in to this file's associated project for copyright � information.
// </copyright>
//-----------------------------------------------------------------------

namespace IdentityServer
{
    using IdentityServer4.Services;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Hosting;
    using Microsoft.Extensions.Logging;
    using System.Threading.Tasks;

    /// <summary>
    /// Home controller.
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    [SecurityHeaders]
    [AllowAnonymous]
    public class HomeController : Controller
    {
        /// <summary>
        /// The environment.
        /// </summary>
        private readonly IWebHostEnvironment _environment;

        /// <summary>
        /// The interaction.
        /// </summary>
        private readonly IIdentityServerInteractionService _interaction;

        /// <summary>
        /// The logger.
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeController"/> class.
        /// </summary>
        /// <param name="interaction">The interaction.</param>
        /// <param name="environment">The environment.</param>
        /// <param name="logger">The logger.</param>
        public HomeController(IIdentityServerInteractionService interaction, IWebHostEnvironment environment, ILogger<HomeController> logger)
        {
            this._interaction = interaction;
            this._environment = environment;
            this._logger = logger;
        }

        /// <summary>
        /// Shows the error page
        /// </summary>
        /// <param name="errorId">The error identifier.</param>
        /// <returns></returns>
        public async Task<IActionResult> Error(string errorId)
        {
            var vm = new ErrorViewModel();

            // retrieve error details from identityserver
            var message = await this._interaction.GetErrorContextAsync(errorId);
            if (message != null)
            {
                vm.Error = message;

                if (!this._environment.IsDevelopment())
                {
                    // only show in development
                    message.ErrorDescription = null;
                }
            }

            return this.View("Error", vm);
        }

        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            if (this._environment.IsDevelopment())
            {
                // only show in development
                return this.View();
            }

            this._logger.LogInformation("Homepage is disabled in production. Returning 404.");
            return this.NotFound();
        }
    }
}