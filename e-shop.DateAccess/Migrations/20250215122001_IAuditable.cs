using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_shop.DateAccess.Migrations
{
    /// <inheritdoc />
    public partial class IAuditable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_at",
                table: "product");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "product");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "category");

            migrationBuilder.DropColumn(
                name: "updated_at",
                table: "category");

            migrationBuilder.RenameColumn(
                name: "created_at",
                table: "customer",
                newName: "create_at");

            migrationBuilder.AddColumn<DateTime>(
                name: "create_at",
                table: "product",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "update_time",
                table: "product",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "customer",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "update_time",
                table: "customer",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "updated_by",
                table: "customer",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "create_at",
                table: "category",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "update_time",
                table: "category",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "create_at",
                table: "card_item",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "card_item",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "update_time",
                table: "card_item",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "updated_by",
                table: "card_item",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "create_at",
                table: "card",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "created_by",
                table: "card",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "update_time",
                table: "card",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "updated_by",
                table: "card",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "category_id",
                keyValue: 1,
                columns: new[] { "create_at", "update_time" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "category_id",
                keyValue: 2,
                columns: new[] { "create_at", "update_time" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "product_id",
                keyValue: 1,
                columns: new[] { "create_at", "update_time" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "product_id",
                keyValue: 2,
                columns: new[] { "create_at", "update_time" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "create_at",
                table: "product");

            migrationBuilder.DropColumn(
                name: "update_time",
                table: "product");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "customer");

            migrationBuilder.DropColumn(
                name: "update_time",
                table: "customer");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "customer");

            migrationBuilder.DropColumn(
                name: "create_at",
                table: "category");

            migrationBuilder.DropColumn(
                name: "update_time",
                table: "category");

            migrationBuilder.DropColumn(
                name: "create_at",
                table: "card_item");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "card_item");

            migrationBuilder.DropColumn(
                name: "update_time",
                table: "card_item");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "card_item");

            migrationBuilder.DropColumn(
                name: "create_at",
                table: "card");

            migrationBuilder.DropColumn(
                name: "created_by",
                table: "card");

            migrationBuilder.DropColumn(
                name: "update_time",
                table: "card");

            migrationBuilder.DropColumn(
                name: "updated_by",
                table: "card");

            migrationBuilder.RenameColumn(
                name: "create_at",
                table: "customer",
                newName: "created_at");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "product",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "product",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "category",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AddColumn<DateTime>(
                name: "updated_at",
                table: "category",
                type: "timestamp with time zone",
                nullable: true,
                defaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "category_id",
                keyValue: 1,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "category",
                keyColumn: "category_id",
                keyValue: 2,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "product_id",
                keyValue: 1,
                columns: new string[0],
                values: new object[0]);

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "product_id",
                keyValue: 2,
                columns: new string[0],
                values: new object[0]);
        }
    }
}
