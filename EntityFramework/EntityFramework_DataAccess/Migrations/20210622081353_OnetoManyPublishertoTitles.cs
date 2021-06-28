using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework_DataAccess.Migrations
{
    public partial class OnetoManyPublishertoTitles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PublishedID",
                table: "Titles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "PublishersPublisherID",
                table: "Titles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    PublisherID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.PublisherID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Titles_PublishersPublisherID",
                table: "Titles",
                column: "PublishersPublisherID");

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_Publishers_PublishersPublisherID",
                table: "Titles",
                column: "PublishersPublisherID",
                principalTable: "Publishers",
                principalColumn: "PublisherID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Titles_Publishers_PublishersPublisherID",
                table: "Titles");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropIndex(
                name: "IX_Titles_PublishersPublisherID",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "PublishersPublisherID",
                table: "Titles");

            migrationBuilder.AlterColumn<string>(
                name: "PublishedID",
                table: "Titles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
