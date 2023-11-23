using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalRProject.DataAccessLayer.Migrations
{
    public partial class fixed_lastcommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_categories_categories_CategoryId1",
                table: "categories");

            migrationBuilder.DropIndex(
                name: "IX_categories_CategoryId1",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "categories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId1",
                table: "categories",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_categories_CategoryId1",
                table: "categories",
                column: "CategoryId1");

            migrationBuilder.AddForeignKey(
                name: "FK_categories_categories_CategoryId1",
                table: "categories",
                column: "CategoryId1",
                principalTable: "categories",
                principalColumn: "CategoryId");
        }
    }
}
