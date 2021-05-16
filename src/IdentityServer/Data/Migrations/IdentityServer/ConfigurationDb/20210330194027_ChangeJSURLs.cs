using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class ChangeJSURLs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 40, 26, 867, DateTimeKind.Utc).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Origin",
                value: "http://localhost:3000");

            migrationBuilder.UpdateData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostLogoutRedirectUri",
                value: "http://localhost:3000/signout-oidc");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 2,
                column: "RedirectUri",
                value: "http://localhost:3000/signin-oidc");

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 40, 26, 871, DateTimeKind.Utc).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 40, 26, 875, DateTimeKind.Utc).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 40, 26, 875, DateTimeKind.Utc).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 40, 26, 870, DateTimeKind.Utc).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 40, 26, 871, DateTimeKind.Utc).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 40, 26, 871, DateTimeKind.Utc).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "RequireConsent" },
                values: new object[] { new DateTime(2021, 3, 30, 19, 40, 26, 871, DateTimeKind.Utc).AddTicks(513), false });

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 40, 26, 869, DateTimeKind.Utc).AddTicks(8010));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 40, 26, 869, DateTimeKind.Utc).AddTicks(9342));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 30, 17, 2, 46, 994, DateTimeKind.Utc).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "ClientCorsOrigins",
                keyColumn: "Id",
                keyValue: 1,
                column: "Origin",
                value: "http://localhost:5003");

            migrationBuilder.UpdateData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostLogoutRedirectUri",
                value: "http://localhost:5003/index.html");

            migrationBuilder.UpdateData(
                table: "ClientRedirectUris",
                keyColumn: "Id",
                keyValue: 2,
                column: "RedirectUri",
                value: "http://localhost:5003/callback.html");

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 30, 17, 2, 46, 999, DateTimeKind.Utc).AddTicks(4841));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 3, 30, 17, 2, 47, 3, DateTimeKind.Utc).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 3, 30, 17, 2, 47, 3, DateTimeKind.Utc).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 30, 17, 2, 46, 998, DateTimeKind.Utc).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 3, 30, 17, 2, 46, 998, DateTimeKind.Utc).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 3, 30, 17, 2, 46, 998, DateTimeKind.Utc).AddTicks(8164));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "RequireConsent" },
                values: new object[] { new DateTime(2021, 3, 30, 17, 2, 46, 998, DateTimeKind.Utc).AddTicks(8165), true });

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 30, 17, 2, 46, 997, DateTimeKind.Utc).AddTicks(5102));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 3, 30, 17, 2, 46, 997, DateTimeKind.Utc).AddTicks(6814));
        }
    }
}
