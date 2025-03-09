using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineSuperMarket.Migrations
{
    /// <inheritdoc />
    public partial class again_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_product_tbl_brand_product_brand",
                table: "tbl_product");

            migrationBuilder.AlterColumn<int>(
                name: "product_brand",
                table: "tbl_product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_product_tbl_brand_product_brand",
                table: "tbl_product",
                column: "product_brand",
                principalTable: "tbl_brand",
                principalColumn: "brand_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_product_tbl_brand_product_brand",
                table: "tbl_product");

            migrationBuilder.AlterColumn<int>(
                name: "product_brand",
                table: "tbl_product",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_product_tbl_brand_product_brand",
                table: "tbl_product",
                column: "product_brand",
                principalTable: "tbl_brand",
                principalColumn: "brand_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
