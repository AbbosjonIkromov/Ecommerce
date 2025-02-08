using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace e_shop.DateAccess.Migrations
{
    /// <inheritdoc />
    public partial class eCommers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    category_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    parent_id = table.Column<int>(type: "integer", nullable: false),
                    category_name = table.Column<string>(type: "text", nullable: false),
                    category_description = table.Column<string>(type: "text", nullable: false),
                    icon = table.Column<string>(type: "text", nullable: false),
                    image_path = table.Column<string>(type: "text", nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    updated_by = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_category", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    product_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    product_name = table.Column<string>(type: "text", nullable: false),
                    sku = table.Column<string>(type: "text", nullable: false),
                    regular_price = table.Column<decimal>(type: "numeric", nullable: false),
                    discount_price = table.Column<decimal>(type: "numeric", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    product_description = table.Column<string>(type: "text", nullable: false),
                    product_weight = table.Column<decimal>(type: "numeric", nullable: false),
                    product_note = table.Column<string>(type: "text", nullable: false),
                    published = table.Column<bool>(type: "boolean", nullable: false),
                    created_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updated_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    created_by = table.Column<int>(type: "integer", nullable: false),
                    updated_by = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_product", x => x.product_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "category");

            migrationBuilder.DropTable(
                name: "product");
        }
    }
}
