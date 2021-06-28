using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework_DataAccess.Migrations
{
    public partial class addTitlesTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    isbn = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    EditionNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CopyRight = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishedID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageFile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.isbn);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Titles");
        }
    }
}
