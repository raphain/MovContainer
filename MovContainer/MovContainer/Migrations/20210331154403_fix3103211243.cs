using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovContainer.Migrations
{
    public partial class fix3103211243 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Containers");

            migrationBuilder.DropTable(
                name: "Movimentations");

            migrationBuilder.DropTable(
                name: "ContainerCategories");

            migrationBuilder.DropTable(
                name: "ContainerStatuses");

            migrationBuilder.DropTable(
                name: "ContainerTypes");

            migrationBuilder.DropTable(
                name: "MovType");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.CreateTable(
                name: "ContainerCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContainerCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContainerStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContainerStatuses", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "Containers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContainerCategoryId = table.Column<int>(type: "int", nullable: false),
                    ContainerStatusId = table.Column<int>(type: "int", nullable: false),
                    ContainerTypeId = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Containers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Containers_ContainerCategories_ContainerCategoryId",
                        column: x => x.ContainerCategoryId,
                        principalTable: "ContainerCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Containers_ContainerStatuses_ContainerStatusId",
                        column: x => x.ContainerStatusId,
                        principalTable: "ContainerStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Containers_ContainerTypes_ContainerTypeId",
                        column: x => x.ContainerTypeId,
                        principalTable: "ContainerTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Movimentations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dt_Fin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dt_Init = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MovTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimentations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movimentations_MovType_MovTypeId",
                        column: x => x.MovTypeId,
                        principalTable: "MovType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Containers_ContainerCategoryId",
                table: "Containers",
                column: "ContainerCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Containers_ContainerStatusId",
                table: "Containers",
                column: "ContainerStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Containers_ContainerTypeId",
                table: "Containers",
                column: "ContainerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Movimentations_MovTypeId",
                table: "Movimentations",
                column: "MovTypeId");*/
        }
    }
}
