using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoWebApi.Migrations
{
    public partial class FkRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProfileId",
                table: "Todo",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Todo_ProfileId",
                table: "Todo",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todo_Person_ProfileId",
                table: "Todo",
                column: "ProfileId",
                principalTable: "Person",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todo_Person_ProfileId",
                table: "Todo");

            migrationBuilder.DropIndex(
                name: "IX_Todo_ProfileId",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "ProfileId",
                table: "Todo");
        }
    }
}
