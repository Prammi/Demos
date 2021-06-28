using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework_DataAccess.Migrations
{
    public partial class OnetoManyPublishertoTitles6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Titles_Publishers_PublishersPublisherID",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_PublishersPublisherID",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "PublishersPublisherID",
                table: "Titles");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublishersPublisherID",
                table: "Titles",
                type: "int",
                nullable: true);

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
    }
}
