using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_shop.DateAccess.Migrations
{
    /// <inheritdoc />
    public partial class modelBuilderExtensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "category",
                columns: new[] { "category_id", "active", "category_description", "category_name", "created_by", "icon", "image_path", "parent_id", "updated_by" },
                values: new object[] { 2, true, "This is crazy", "Sports", 0, "_dd", "image", 1, 0 });

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "product_id", "created_by", "discount_price", "product_description", "product_name", "product_note", "product_weight", "published", "quantity", "regular_price", "sku", "updated_by" },
                values: new object[] { 2, 0, 70000m, "Awesome", "Ball", "Sports", 0m, true, 13, 75000m, "bb", 0 });

            migrationBuilder.InsertData(
                table: "product_category",
                columns: new[] { "category_id", "product_id" },
                values: new object[] { 2, 2 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product_category",
                keyColumns: new[] { "category_id", "product_id" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "category",
                keyColumn: "category_id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "product_id",
                keyValue: 2);
        }
    }
}
