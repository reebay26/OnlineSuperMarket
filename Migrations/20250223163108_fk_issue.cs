using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineSuperMarket.Migrations
{
    /// <inheritdoc />
    public partial class fk_issue : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_product_category_category_id",
                table: "tbl_product");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_product_tbl_brand_brand_id",
                table: "tbl_product");

            migrationBuilder.RenameColumn(
                name: "category_id",
                table: "tbl_product",
                newName: "Category_id");

            migrationBuilder.RenameColumn(
                name: "brand_id",
                table: "tbl_product",
                newName: "Brand_id");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_product_category_id",
                table: "tbl_product",
                newName: "IX_tbl_product_Category_id");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_product_brand_id",
                table: "tbl_product",
                newName: "IX_tbl_product_Brand_id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_product_category_Category_id",
                table: "tbl_product",
                column: "Category_id",
                principalTable: "category",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_product_tbl_brand_Brand_id",
                table: "tbl_product",
                column: "Brand_id",
                principalTable: "tbl_brand",
                principalColumn: "brand_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_product_category_Category_id",
                table: "tbl_product");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_product_tbl_brand_Brand_id",
                table: "tbl_product");

            migrationBuilder.RenameColumn(
                name: "Category_id",
                table: "tbl_product",
                newName: "category_id");

            migrationBuilder.RenameColumn(
                name: "Brand_id",
                table: "tbl_product",
                newName: "brand_id");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_product_Category_id",
                table: "tbl_product",
                newName: "IX_tbl_product_category_id");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_product_Brand_id",
                table: "tbl_product",
                newName: "IX_tbl_product_brand_id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_product_category_category_id",
                table: "tbl_product",
                column: "category_id",
                principalTable: "category",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_product_tbl_brand_brand_id",
                table: "tbl_product",
                column: "brand_id",
                principalTable: "tbl_brand",
                principalColumn: "brand_id");
        }
    }
}
