//-----------------------------------------------------------------------
// <copyright file="AccountOptions.cs" company="Patel">
//     See the [assembly: AssemblyCopyright(..)] marking attribute linked in to this file's associated project for copyright © information.
// </copyright>
//-----------------------------------------------------------------------

namespace IdentityServer
{
    using System;

    /// <summary>
    /// Account option class.
    /// </summary>
    public class AccountOptions
    {
        // specify the Windows authentication scheme being used
        /// <summary>
        /// The windows authentication scheme name
        /// </summary>
        public static readonly string WindowsAuthenticationSchemeName = Microsoft.AspNetCore.Server.IISIntegration.IISDefaults.AuthenticationScheme;

        /// <summary>
        /// The allow local login
        /// </summary>
        public static bool AllowLocalLogin = true;

        /// <summary>
        /// The allow remember login
        /// </summary>
        public static bool AllowRememberLogin = true;

        /// <summary>
        /// The automatic redirect after sign out
        /// </summary>
        public static bool AutomaticRedirectAfterSignOut = true;

        // if user uses windows auth, should we load the groups from windows
        /// <summary>
        /// The include windows groups
        /// </summary>
        public static bool IncludeWindowsGroups = false;

        /// <summary>
        /// The invalid credentials error message
        /// </summary>
        public static string InvalidCredentialsErrorMessage = "Invalid credentials or disabled user";

        /// <summary>
        /// The remember me login duration
        /// </summary>
        public static TimeSpan RememberMeLoginDuration = TimeSpan.FromDays(30);

        /// <summary>
        /// The show logout prompt
        /// </summary>
        public static bool ShowLogoutPrompt = true;
    }
}