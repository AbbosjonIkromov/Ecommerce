using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_shop.DateAccess.Migrations
{
    /// <inheritdoc />
    public partial class addedOrderSummary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "order_summaries",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false),
                    full_name = table.Column<string>(type: "text", nullable: false),
                    order_approved_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "order_summaries");
        }
    }
}
