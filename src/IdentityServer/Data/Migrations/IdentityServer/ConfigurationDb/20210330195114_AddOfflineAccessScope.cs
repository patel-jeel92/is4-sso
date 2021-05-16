using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class AddOfflineAccessScope : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 51, 14, 92, DateTimeKind.Utc).AddTicks(6144));

            migrationBuilder.InsertData(
                table: "ClientScopes",
                columns: new[] { "Id", "ClientId", "Scope" },
                values: new object[,]
                {
                    { 9, 3, "offline_access" },
                    { 10, 4, "offline_access" }
                });

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
                columns: new[] { "AllowOfflineAccess", "Created" },
                values: new object[] { true, new DateTime(2021, 3, 30, 19, 51, 14, 97, DateTimeKind.Utc).AddTicks(115) });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ClientScopes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 30, 19, 40, 26, 867, DateTimeKind.Utc).AddTicks(4482));

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
                columns: new[] { "AllowOfflineAccess", "Created" },
                values: new object[] { false, new DateTime(2021, 3, 30, 19, 40, 26, 871, DateTimeKind.Utc).AddTicks(513) });

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
    }
}
