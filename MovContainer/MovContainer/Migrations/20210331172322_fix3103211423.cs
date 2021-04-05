using Microsoft.EntityFrameworkCore.Migrations;

namespace MovContainer.Migrations
{
    public partial class fix3103211423 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimentations_MovType_MovTypeId",
                table: "Movimentations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovType",
                table: "MovType");

            migrationBuilder.RenameTable(
                name: "MovType",
                newName: "MovTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovTypes",
                table: "MovTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentations_MovTypes_MovTypeId",
                table: "Movimentations",
                column: "MovTypeId",
                principalTable: "MovTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimentations_MovTypes_MovTypeId",
                table: "Movimentations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovTypes",
                table: "MovTypes");

            migrationBuilder.RenameTable(
                name: "MovTypes",
                newName: "MovType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovType",
                table: "MovType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentations_MovType_MovTypeId",
                table: "Movimentations",
                column: "MovTypeId",
                principalTable: "MovType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
