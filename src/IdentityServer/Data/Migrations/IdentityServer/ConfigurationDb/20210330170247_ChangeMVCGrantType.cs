using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityServer.Data.Migrations.IdentityServer.ConfigurationDb
{
    public partial class ChangeMVCGrantType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApiResources",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2021, 3, 30, 17, 2, 46, 994, DateTimeKind.Utc).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "ClientGrantTypes",
                keyColumn: "Id",
                keyValue: 3,
                column: "GrantType",
                value: "authorization_code");

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
                column: "Created",
                value: new DateTime(2021, 3, 30, 17, 2, 46, 998, DateTimeKind.Utc).AddTicks(8165));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
