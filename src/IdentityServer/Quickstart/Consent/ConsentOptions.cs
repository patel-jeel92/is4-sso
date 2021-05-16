//-----------------------------------------------------------------------
// <copyright file="ConsentOptions.cs" company="Patel">
//     See the [assembly: AssemblyCopyright(..)] marking attribute linked in to this file's associated project for copyright © information.
// </copyright>
//-----------------------------------------------------------------------
namespace IdentityServer
{
    /// <summary>
    /// Consent option class.
    /// </summary>
    public class ConsentOptions
    {
        /// <summary>
        /// The invalid selection error message
        /// </summary>
        public static readonly string InvalidSelectionErrorMessage = "Invalid selection";

        /// <summary>
        /// The must choose one error message
        /// </summary>
        public static readonly string MustChooseOneErrorMessage = "You must pick at least one permission";

        /// <summary>
        /// The enable offline access
        /// </summary>
        public static bool EnableOfflineAccess = true;

        /// <summary>
        /// The offline access description
        /// </summary>
        public static string OfflineAccessDescription = "Access to your applications and resources, even when you are offline";

        /// <summary>
        /// The offline access display name
        /// </summary>
        public static string OfflineAccessDisplayName = "Offline Access";
    }
}