using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Nutrify.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Units",
                table: "Nutrient",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "Id", "Category", "Name", "NutrientId", "ServingSize" },
                values: new object[,]
                {
                    { 1, "Protein", "Chicken Breast", 1, 100 },
                    { 2, "Grain", "Rice", 2, 100 },
                    { 3, "Fruits", "Apple", 3, 1 }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "Id", "Date", "FoodId", "MealType" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 12, 20, 54, 33, 913, DateTimeKind.Local).AddTicks(2285), 0, "Breakfast" },
                    { 2, new DateTime(2025, 2, 12, 20, 54, 33, 913, DateTimeKind.Local).AddTicks(2296), 0, "Lunch" },
                    { 3, new DateTime(2025, 2, 12, 20, 54, 33, 913, DateTimeKind.Local).AddTicks(2297), 0, "Dinner" },
                    { 4, new DateTime(2025, 2, 12, 20, 54, 33, 913, DateTimeKind.Local).AddTicks(2298), 0, "Snack" }
                });

            migrationBuilder.InsertData(
                table: "Nutrient",
                columns: new[] { "Id", "Name", "Units" },
                values: new object[,]
                {
                    { 1, "Protein", "g" },
                    { 2, "Carbohydrates", "g" },
                    { 3, "Vitamins", "mg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Food",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Nutrient",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nutrient",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nutrient",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "Units",
                table: "Nutrient",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
