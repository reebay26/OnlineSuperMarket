using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineSuperMarket.Migrations
{
    /// <inheritdoc />
    public partial class image_work : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductImage",
                table: "tbl_product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductImage",
                table: "tbl_product");
        }
    }
}
