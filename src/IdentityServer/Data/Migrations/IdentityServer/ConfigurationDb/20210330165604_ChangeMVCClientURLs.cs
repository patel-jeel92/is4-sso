using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class ChangeMVCClientURLs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 30, 16, 56, 3, 474, DateTimeKind.Utc).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "ClientGrantTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "GrantType",
                value: "code");

            migrationBuilder.UpdateData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostLogoutRedirectUri",
                value: "https://localhost:44359/signout-callback-oidc");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 1,
                column: "RedirectUri",
                value: "https://localhost:44359/signin-oidc");

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 30, 16, 56, 3, 478, DateTimeKind.Utc).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 3, 30, 16, 56, 3, 481, DateTimeKind.Utc).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 3, 30, 16, 56, 3, 482, DateTimeKind.Utc).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 30, 16, 56, 3, 477, DateTimeKind.Utc).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 3, 30, 16, 56, 3, 478, DateTimeKind.Utc).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 3, 30, 16, 56, 3, 478, DateTimeKind.Utc).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 3, 30, 16, 56, 3, 478, DateTimeKind.Utc).AddTicks(3895));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 30, 16, 56, 3, 476, DateTimeKind.Utc).AddTicks(9284));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 3, 30, 16, 56, 3, 477, DateTimeKind.Utc).AddTicks(665));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 590, DateTimeKind.Utc).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "ClientGrantTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "GrantType",
                value: "hybrid");

            migrationBuilder.UpdateData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 1,
                column: "PostLogoutRedirectUri",
                value: "http://localhost:5002/signout-callback-oidc");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 1,
                column: "RedirectUri",
                value: "http://localhost:5002/signin-oidc");

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 592, DateTimeKind.Utc).AddTicks(7212));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 594, DateTimeKind.Utc).AddTicks(6993));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 594, DateTimeKind.Utc).AddTicks(7257));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 592, DateTimeKind.Utc).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 592, DateTimeKind.Utc).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 592, DateTimeKind.Utc).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 592, DateTimeKind.Utc).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 591, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2020, 1, 27, 9, 42, 1, 591, DateTimeKind.Utc).AddTicks(8400));
        }
    }
}
