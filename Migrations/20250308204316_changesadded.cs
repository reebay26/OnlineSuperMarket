using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineSuperMarket.Migrations
{
    /// <inheritdoc />
    public partial class changesadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_Items_tbl_Order_Order_id1",
                table: "order_Items");

            migrationBuilder.DropIndex(
                name: "IX_order_Items_Order_id1",
                table: "order_Items");

            migrationBuilder.DropColumn(
                name: "Order_id1",
                table: "order_Items");

            migrationBuilder.CreateIndex(
                name: "IX_order_Items_Order_id",
                table: "order_Items",
                column: "Order_id");

            migrationBuilder.AddForeignKey(
                name: "FK_order_Items_tbl_Order_Order_id",
                table: "order_Items",
                column: "Order_id",
                principalTable: "tbl_Order",
                principalColumn: "Order_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_Items_tbl_Order_Order_id",
                table: "order_Items");

            migrationBuilder.DropIndex(
                name: "IX_order_Items_Order_id",
                table: "order_Items");

            migrationBuilder.AddColumn<int>(
                name: "Order_id1",
                table: "order_Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_order_Items_Order_id1",
                table: "order_Items",
                column: "Order_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_order_Items_tbl_Order_Order_id1",
                table: "order_Items",
                column: "Order_id1",
                principalTable: "tbl_Order",
                principalColumn: "Order_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
