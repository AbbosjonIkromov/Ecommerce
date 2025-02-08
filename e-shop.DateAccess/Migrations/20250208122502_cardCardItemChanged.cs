using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_shop.DateAccess.Migrations
{
    /// <inheritdoc />
    public partial class cardCardItemChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "ix_card_item_product_id",
                table: "card_item",
                column: "product_id");

            migrationBuilder.CreateIndex(
                name: "ix_card_customer_id",
                table: "card",
                column: "customer_id");

            migrationBuilder.AddForeignKey(
                name: "fk_card_customer_customer_id",
                table: "card",
                column: "customer_id",
                principalTable: "customer",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_card_item_product_product_id",
                table: "card_item",
                column: "product_id",
                principalTable: "product",
                principalColumn: "product_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_card_customer_customer_id",
                table: "card");

            migrationBuilder.DropForeignKey(
                name: "fk_card_item_product_product_id",
                table: "card_item");

            migrationBuilder.DropIndex(
                name: "ix_card_item_product_id",
                table: "card_item");

            migrationBuilder.DropIndex(
                name: "ix_card_customer_id",
                table: "card");
        }
    }
}
