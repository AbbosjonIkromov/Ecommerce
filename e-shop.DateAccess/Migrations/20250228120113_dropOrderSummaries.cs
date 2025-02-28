using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_shop.DateAccess.Migrations
{
    /// <inheritdoc />
    public partial class dropOrderSummaries : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "order_summaries",
                columns: table => new
                {
                    full_name = table.Column<string>(type: "text", nullable: false),
                    id = table.Column<int>(type: "integer", nullable: false),
                    order_approved_at = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                });
        }
    }
}
