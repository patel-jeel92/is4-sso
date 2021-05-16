//-----------------------------------------------------------------------
// <copyright file="ErrorViewModel.cs" company="Patel">
//     See the [assembly: AssemblyCopyright(..)] marking attribute linked in to this file's associated project for copyright © information.
// </copyright>
//-----------------------------------------------------------------------

namespace IdentityServer
{
    using IdentityServer4.Models;

    /// <summary>
    /// Error view model class.
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorViewModel"/> class.
        /// </summary>
        public ErrorViewModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorViewModel"/> class.
        /// </summary>
        /// <param name="error">The error.</param>
        public ErrorViewModel(string error)
        {
            this.Error = new ErrorMessage { Error = error };
        }

        /// <summary>
        /// Gets or sets the error.
        /// </summary>
        /// <value>
        /// The error.
        /// </value>
        public ErrorMessage Error { get; set; }
    }
}