using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramework_DataAccess.Migrations
{
    public partial class OnetoManyPublishertoTitles10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Publisher_ID",
                table: "Titles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Titles_Publisher_ID",
                table: "Titles",
                column: "Publisher_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Titles_Publishers_Publisher_ID",
                table: "Titles",
                column: "Publisher_ID",
                principalTable: "Publishers",
                principalColumn: "PublisherID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Titles_Publishers_Publisher_ID",
                table: "Titles");

            migrationBuilder.DropIndex(
                name: "IX_Titles_Publisher_ID",
                table: "Titles");

            migrationBuilder.DropColumn(
                name: "Publisher_ID",
                table: "Titles");
        }
    }
}
