using Microsoft.EntityFrameworkCore.Migrations;

namespace MovContainer.Migrations
{
    public partial class fix3103211620 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ContainerId",
                table: "Movimentations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movimentations_ContainerId",
                table: "Movimentations",
                column: "ContainerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentations_Containers_ContainerId",
                table: "Movimentations",
                column: "ContainerId",
                principalTable: "Containers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimentations_Containers_ContainerId",
                table: "Movimentations");

            migrationBuilder.DropIndex(
                name: "IX_Movimentations_ContainerId",
                table: "Movimentations");

            migrationBuilder.DropColumn(
                name: "ContainerId",
                table: "Movimentations");
        }
    }
}
