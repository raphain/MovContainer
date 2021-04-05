using Microsoft.EntityFrameworkCore.Migrations;

namespace MovContainer.Migrations
{
    public partial class Fix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type_Mov",
                table: "Movimentations");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Containers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Containers");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Containers",
                newName: "Client");

            migrationBuilder.AddColumn<int>(
                name: "Type_MovId",
                table: "Movimentations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Containers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Containers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Containers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ContainerCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContainerCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContainerStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContainerStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContainerType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContainerType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movimentations_Type_MovId",
                table: "Movimentations",
                column: "Type_MovId");

            migrationBuilder.CreateIndex(
                name: "IX_Containers_CategoryId",
                table: "Containers",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Containers_StatusId",
                table: "Containers",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Containers_TypeId",
                table: "Containers",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_ContainerCategory_CategoryId",
                table: "Containers",
                column: "CategoryId",
                principalTable: "ContainerCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_ContainerStatus_StatusId",
                table: "Containers",
                column: "StatusId",
                principalTable: "ContainerStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_ContainerType_TypeId",
                table: "Containers",
                column: "TypeId",
                principalTable: "ContainerType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentations_MovType_Type_MovId",
                table: "Movimentations",
                column: "Type_MovId",
                principalTable: "MovType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Containers_ContainerCategory_CategoryId",
                table: "Containers");

            migrationBuilder.DropForeignKey(
                name: "FK_Containers_ContainerStatus_StatusId",
                table: "Containers");

            migrationBuilder.DropForeignKey(
                name: "FK_Containers_ContainerType_TypeId",
                table: "Containers");

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentations_MovType_Type_MovId",
                table: "Movimentations");

            migrationBuilder.DropTable(
                name: "ContainerCategory");

            migrationBuilder.DropTable(
                name: "ContainerStatus");

            migrationBuilder.DropTable(
                name: "ContainerType");

            migrationBuilder.DropTable(
                name: "MovType");

            migrationBuilder.DropIndex(
                name: "IX_Movimentations_Type_MovId",
                table: "Movimentations");

            migrationBuilder.DropIndex(
                name: "IX_Containers_CategoryId",
                table: "Containers");

            migrationBuilder.DropIndex(
                name: "IX_Containers_StatusId",
                table: "Containers");

            migrationBuilder.DropIndex(
                name: "IX_Containers_TypeId",
                table: "Containers");

            migrationBuilder.DropColumn(
                name: "Type_MovId",
                table: "Movimentations");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Containers");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Containers");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Containers");

            migrationBuilder.RenameColumn(
                name: "Client",
                table: "Containers",
                newName: "Type");

            migrationBuilder.AddColumn<string>(
                name: "Type_Mov",
                table: "Movimentations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Containers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Containers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
