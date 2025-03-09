using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineSuperMarket.Migrations
{
    /// <inheritdoc />
    public partial class contact_form : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_contact",
                columns: table => new
                {
                    Contact_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Contact_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_contact", x => x.Contact_id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_contact");
        }
    }
}
