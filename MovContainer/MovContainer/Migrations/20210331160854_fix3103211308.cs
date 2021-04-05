using Microsoft.EntityFrameworkCore.Migrations;

namespace MovContainer.Migrations
{
    public partial class fix3103211308 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "ContainerTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContainerTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Container",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContainerTypeId = table.Column<int>(type: "int", nullable: false),
                    ContainerStatusId = table.Column<int>(type: "int", nullable: false),
                    ContainerCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Container", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Container_ContainerCategory_ContainerCategoryId",
                        column: x => x.ContainerCategoryId,
                        principalTable: "ContainerCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Container_ContainerStatus_ContainerStatusId",
                        column: x => x.ContainerStatusId,
                        principalTable: "ContainerStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Container_ContainerTypes_ContainerTypeId",
                        column: x => x.ContainerTypeId,
                        principalTable: "ContainerTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Container_ContainerCategoryId",
                table: "Container",
                column: "ContainerCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Container_ContainerStatusId",
                table: "Container",
                column: "ContainerStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Container_ContainerTypeId",
                table: "Container",
                column: "ContainerTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Container");

            migrationBuilder.DropTable(
                name: "ContainerCategory");

            migrationBuilder.DropTable(
                name: "ContainerStatus");

            migrationBuilder.DropTable(
                name: "ContainerTypes");
        }
    }
}
