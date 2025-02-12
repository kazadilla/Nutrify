using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nutrify.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Trainer", "TRAINER" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "d778afee-dbbe-476c-9d8a-931f33cdbb94", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEF8OmEQ3xVoosA7FvpTOJSx2w6It54jHnI0EX12hMQQ8PixMLEDPuaiQRCVMvfCCyw==", null, false, "f5c14384-964b-4e19-9d3a-296940ebe5c5", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Meal",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 2, 12, 21, 15, 39, 470, DateTimeKind.Local).AddTicks(4262));

            migrationBuilder.UpdateData(
                table: "Meal",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 2, 12, 21, 15, 39, 470, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "Meal",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 2, 12, 21, 15, 39, 470, DateTimeKind.Local).AddTicks(4273));

            migrationBuilder.UpdateData(
                table: "Meal",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 2, 12, 21, 15, 39, 470, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Meal",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2025, 2, 12, 21, 0, 57, 499, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "Meal",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2025, 2, 12, 21, 0, 57, 499, DateTimeKind.Local).AddTicks(9043));

            migrationBuilder.UpdateData(
                table: "Meal",
                keyColumn: "Id",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2025, 2, 12, 21, 0, 57, 499, DateTimeKind.Local).AddTicks(9044));

            migrationBuilder.UpdateData(
                table: "Meal",
                keyColumn: "Id",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2025, 2, 12, 21, 0, 57, 499, DateTimeKind.Local).AddTicks(9044));
        }
    }
}
