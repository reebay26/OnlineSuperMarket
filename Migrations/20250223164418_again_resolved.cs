using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineSuperMarket.Migrations
{
    /// <inheritdoc />
    public partial class again_resolved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_product_category_Category_id",
                table: "tbl_product");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_product_tbl_brand_Brand_id",
                table: "tbl_product");

            migrationBuilder.DropIndex(
                name: "IX_tbl_product_Brand_id",
                table: "tbl_product");

            migrationBuilder.DropColumn(
                name: "Brand_id",
                table: "tbl_product");

            migrationBuilder.RenameColumn(
                name: "Category_id",
                table: "tbl_product",
                newName: "product_category");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_product_Category_id",
                table: "tbl_product",
                newName: "IX_tbl_product_product_category");

            migrationBuilder.AddColumn<int>(
                name: "product_brand",
                table: "tbl_product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_product_product_brand",
                table: "tbl_product",
                column: "product_brand");

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_product_category_product_category",
                table: "tbl_product",
                column: "product_category",
                principalTable: "category",
                principalColumn: "category_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tbl_product_tbl_brand_product_brand",
                table: "tbl_product",
                column: "product_brand",
                principalTable: "tbl_brand",
                principalColumn: "brand_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbl_product_category_product_category",
                table: "tbl_product");

            migrationBuilder.DropForeignKey(
                name: "FK_tbl_product_tbl_brand_product_brand",
                table: "tbl_product");

            migrationBuilder.DropIndex(
                name: "IX_tbl_product_product_brand",
                table: "tbl_product");

            migrationBuilder.DropColumn(
                name: "product_brand",
                table: "tbl_product");

            migrationBuilder.RenameColumn(
                name: "product_category",
                table: "tbl_product",
                newName: "Category_id");

            migrationBuilder.RenameIndex(
                name: "IX_tbl_product_product_category",
                table: "tbl_product",
                newName: "IX_tbl_product_Category_id");

            migrationBuilder.AddColumn<int>(
                name: "Brand_id",
                table: "tbl_product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tbl_product_Brand_id",
                table: "tbl_product",
                column: "Brand_id");

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
    }
}
