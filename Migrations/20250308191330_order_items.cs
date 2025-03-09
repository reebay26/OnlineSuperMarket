using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineSuperMarket.Migrations
{
    /// <inheritdoc />
    public partial class order_items : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "order_Items",
                columns: table => new
                {
                    OrderItem_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_id = table.Column<int>(type: "int", nullable: false),
                    Order_id1 = table.Column<int>(type: "int", nullable: false),
                    Product_id = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_Items", x => x.OrderItem_id);
                    table.ForeignKey(
                        name: "FK_order_Items_tbl_Order_Order_id1",
                        column: x => x.Order_id1,
                        principalTable: "tbl_Order",
                        principalColumn: "Order_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_order_Items_tbl_product_Product_id",
                        column: x => x.Product_id,
                        principalTable: "tbl_product",
                        principalColumn: "Product_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_order_Items_Order_id1",
                table: "order_Items",
                column: "Order_id1");

            migrationBuilder.CreateIndex(
                name: "IX_order_Items_Product_id",
                table: "order_Items",
                column: "Product_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "order_Items");
        }
    }
}
