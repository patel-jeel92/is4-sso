﻿//-----------------------------------------------------------------------
// <copyright file="ConfigurationDbContext.cs" company="Patel">
//     See the [assembly: AssemblyCopyright(..)] marking attribute linked in to this file's associated project for copyright © information.
// </copyright>
//-----------------------------------------------------------------------

namespace IdentityServer.Data
{
    using IdentityModel;
    using IdentityServer4.EntityFramework.Entities;
    using IdentityServer4.EntityFramework.Extensions;
    using IdentityServer4.EntityFramework.Options;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Configuration DB Context class.
    /// </summary>
    /// <seealso cref="IdentityServer4.EntityFramework.DbContexts.ConfigurationDbContext{IdentityServer.Data.ConfigurationDbContext}" />
    public class ConfigurationDbContext : IdentityServer4.EntityFramework.DbContexts.ConfigurationDbContext<ConfigurationDbContext>
    {
        /// <summary>
        /// The store options
        /// </summary>
        private readonly ConfigurationStoreOptions _storeOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationDbContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        /// <param name="storeOptions">The store options.</param>
        public ConfigurationDbContext(DbContextOptions<ConfigurationDbContext> options, ConfigurationStoreOptions storeOptions) : base(options, storeOptions)
        {
            this._storeOptions = storeOptions;
        }

        /// <summary>
        /// Override this method to further configure the model that was discovered by convention from the entity types
        /// exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on your derived context. The resulting model may be cached
        /// and re-used for subsequent instances of your derived context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context. Databases (and other extensions) typically
        /// define extension methods on this object that allow you to configure aspects of the model that are specific
        /// to a given database.</param>
        /// <remarks>
        /// If a model is explicitly set on the options for this context (via <see cref="M:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)" />)
        /// then this method will not be run.
        /// </remarks>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureClientContext(this._storeOptions);
            modelBuilder.ConfigureResourcesContext(this._storeOptions);

            base.OnModelCreating(modelBuilder);

            this.ClientSeed(modelBuilder);
        }

        /// <summary>
        /// Clients the seed.
        /// </summary>
        /// <param name="builder">The builder.</param>
        private void ClientSeed(ModelBuilder builder)
        {
            builder.Entity<ApiResource>()
                .HasData(
                    new ApiResource
                    {
                        Id = 1,
                        Name = "web_api",
                        DisplayName = "My Web API"
                    }
                );

            builder.Entity<ApiScope>()
                .HasData(
                    new ApiScope
                    {
                        Id = 1,
                        Name = "web_api",
                        DisplayName = "web_api",
                        Description = null,
                        Required = false,
                        Emphasize = false,
                        ShowInDiscoveryDocument = true,
                        ApiResourceId = 1
                    }
                );

            builder.Entity<IdentityResource>().HasData
                (
                    new IdentityResource()
                    {
                        Id = 1,
                        Enabled = true,
                        Name = "openid",
                        DisplayName = "Your user identifier",
                        Description = null,
                        Required = true,
                        Emphasize = false,
                        ShowInDiscoveryDocument = true,
                        Created = DateTime.UtcNow,
                        Updated = null,
                        NonEditable = false
                    },
                    new IdentityResource()
                    {
                        Id = 2,
                        Enabled = true,
                        Name = "profile",
                        DisplayName = "User profile",
                        Description = "Your user profile information (first name, last name, etc.)",
                        Required = false,
                        Emphasize = true,
                        ShowInDiscoveryDocument = true,
                        Created = DateTime.UtcNow,
                        Updated = null,
                        NonEditable = false
                    });

            builder.Entity<ClientRedirectUri>()
                .HasData(
                new ClientRedirectUri
                {
                    Id = 1,
                    RedirectUri = "https://localhost:44359/signin-oidc",
                    ClientId = 3
                },
                new ClientRedirectUri
                {
                    Id = 2,
                    RedirectUri = "http://localhost:3000/signin-oidc",
                    ClientId = 4
                });

            builder.Entity<IdentityClaim>()
                .HasData(
                    new IdentityClaim
                    {
                        Id = 1,
                        IdentityResourceId = 1,
                        Type = "sub"
                    },
                    new IdentityClaim
                    {
                        Id = 2,
                        IdentityResourceId = 2,
                        Type = "email"
                    },
                    new IdentityClaim
                    {
                        Id = 3,
                        IdentityResourceId = 2,
                        Type = "website"
                    },
                    new IdentityClaim
                    {
                        Id = 4,
                        IdentityResourceId = 2,
                        Type = "given_name"
                    },
                    new IdentityClaim
                    {
                        Id = 5,
                        IdentityResourceId = 2,
                        Type = "family_name"
                    },
                    new IdentityClaim
                    {
                        Id = 6,
                        IdentityResourceId = 2,
                        Type = "name"
                    });

            builder.Entity<Client>()
                .HasData(
                    new Client
                    {
                        Id = 1,
                        Enabled = true,
                        ClientId = "client",
                        ProtocolType = "oidc",
                        RequireClientSecret = true,
                        RequireConsent = true,
                        ClientName = null,
                        Description = null,
                        AllowRememberConsent = true,
                        AlwaysIncludeUserClaimsInIdToken = false,
                        RequirePkce = false,
                        AllowAccessTokensViaBrowser = false,
                        AllowOfflineAccess = false
                    },
                    new Client
                    {
                        Id = 2,
                        Enabled = true,
                        ClientId = "ro.client",
                        ProtocolType = "oidc",
                        RequireClientSecret = true,
                        RequireConsent = true,
                        ClientName = null,
                        Description = null,
                        AllowRememberConsent = true,
                        AlwaysIncludeUserClaimsInIdToken = false,
                        RequirePkce = false,
                        AllowAccessTokensViaBrowser = false,
                        AllowOfflineAccess = false
                    },
                    new Client
                    {
                        Id = 3,
                        Enabled = true,
                        ClientId = "mvc",
                        ProtocolType = "oidc",
                        RequireClientSecret = true,
                        RequireConsent = true,
                        ClientName = "MVC Client",
                        Description = null,
                        AllowRememberConsent = true,
                        AlwaysIncludeUserClaimsInIdToken = false,
                        RequirePkce = false,
                        AllowAccessTokensViaBrowser = false,
                        AllowOfflineAccess = true
                    },
                    new Client
                    {
                        Id = 4,
                        Enabled = true,
                        ClientId = "js",
                        ProtocolType = "oidc",
                        RequireClientSecret = false,
                        RequireConsent = false,
                        ClientName = "JavaScript client",
                        Description = null,
                        AllowRememberConsent = true,
                        AlwaysIncludeUserClaimsInIdToken = false,
                        RequirePkce = true,
                        AllowAccessTokensViaBrowser = false,
                        AllowOfflineAccess = true
                    });

            builder.Entity<ClientGrantType>()
                .HasData(
                    new ClientGrantType
                    {
                        Id = 1,
                        GrantType = "client_credentials",
                        ClientId = 1
                    },
                    new ClientGrantType
                    {
                        Id = 2,
                        GrantType = "password",
                        ClientId = 2
                    },
                    new ClientGrantType
                    {
                        Id = 3,
                        GrantType = "authorization_code",
                        ClientId = 3
                    },
                    new ClientGrantType
                    {
                        Id = 4,
                        GrantType = "authorization_code",
                        ClientId = 4
                    });

            builder.Entity<ClientScope>()
                .HasData(
                    new ClientScope
                    {
                        Id = 1,
                        Scope = "profile",
                        ClientId = 3
                    },
                    new ClientScope
                    {
                        Id = 2,
                        Scope = "profile",
                        ClientId = 4
                    },
                    new ClientScope
                    {
                        Id = 3,
                        Scope = "openid",
                        ClientId = 3
                    },
                    new ClientScope
                    {
                        Id = 4,
                        Scope = "openid",
                        ClientId = 4
                    },
                    new ClientScope
                    {
                        Id = 5,
                        Scope = "web_api",
                        ClientId = 1
                    }
                    ,
                    new ClientScope
                    {
                        Id = 6,
                        Scope = "web_api",
                        ClientId = 2
                    }
                    ,
                    new ClientScope
                    {
                        Id = 7,
                        Scope = "web_api",
                        ClientId = 3
                    }
                    ,
                    new ClientScope
                    {
                        Id = 8,
                        Scope = "web_api",
                        ClientId = 4
                    },
                    new ClientScope
                    {
                        Id = 9,
                        Scope = "offline_access",
                        ClientId = 3
                    },
                    new ClientScope
                    {
                        Id = 10,
                        Scope = "offline_access",
                        ClientId = 4
                    });

            builder.Entity<ClientSecret>()
                .HasData(
                     new ClientSecret
                     {
                         Id = 1,
                         Value = "secret".ToSha256(),
                         Type = "SharedSecret",
                         ClientId = 1
                     },
                     new ClientSecret
                     {
                         Id = 2,
                         Value = "secret".ToSha256(),
                         Type = "SharedSecret",
                         ClientId = 2
                     },
                     new ClientSecret
                     {
                         Id = 3,
                         Value = "secret".ToSha256(),
                         Type = "SharedSecret",
                         ClientId = 3
                     });

            builder.Entity<ClientPostLogoutRedirectUri>()
                .HasData(
                new ClientPostLogoutRedirectUri
                {
                    Id = 1,
                    PostLogoutRedirectUri = "https://localhost:44359/signout-callback-oidc",
                    ClientId = 3
                },
                new ClientPostLogoutRedirectUri
                {
                    Id = 2,
                    PostLogoutRedirectUri = "http://localhost:3000/login",
                    ClientId = 4
                });

            builder.Entity<ClientCorsOrigin>()
                .HasData(
                new ClientCorsOrigin
                {
                    Id = 1,
                    Origin = "http://localhost:3000",
                    ClientId = 4
                });
        }
    }
}