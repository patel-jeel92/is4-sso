using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class ChangeJSSignoutURL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 31, 17, 27, 41, 298, DateTimeKind.Utc).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostLogoutRedirectUri",
                value: "http://localhost:3000/signout-callback-oidc");

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 31, 17, 27, 41, 304, DateTimeKind.Utc).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 3, 31, 17, 27, 41, 309, DateTimeKind.Utc).AddTicks(3015));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 3, 31, 17, 27, 41, 309, DateTimeKind.Utc).AddTicks(3589));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 31, 17, 27, 41, 303, DateTimeKind.Utc).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 3, 31, 17, 27, 41, 303, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 3, 31, 17, 27, 41, 303, DateTimeKind.Utc).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 3, 31, 17, 27, 41, 303, DateTimeKind.Utc).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 31, 17, 27, 41, 302, DateTimeKind.Utc).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 3, 31, 17, 27, 41, 302, DateTimeKind.Utc).AddTicks(3916));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 51, 14, 92, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.UpdateData(
                table: "ClientPostLogoutRedirectUris",
                keyColumn: "Id",
                keyValue: 2,
                column: "PostLogoutRedirectUri",
                value: "http://localhost:3000/signout-oidc");

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 51, 14, 97, DateTimeKind.Utc).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 51, 14, 100, DateTimeKind.Utc).AddTicks(4355));

            migrationBuilder.UpdateData(
                table: "ClientSecrets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 51, 14, 100, DateTimeKind.Utc).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 51, 14, 96, DateTimeKind.Utc).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 51, 14, 97, DateTimeKind.Utc).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 51, 14, 97, DateTimeKind.Utc).AddTicks(112));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 51, 14, 97, DateTimeKind.Utc).AddTicks(115));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 51, 14, 95, DateTimeKind.Utc).AddTicks(6896));

            migrationBuilder.UpdateData(
                table: "IdentityResources",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 51, 14, 95, DateTimeKind.Utc).AddTicks(8416));
        }
    }
}
