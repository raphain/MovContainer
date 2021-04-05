using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovContainer.Migrations
{
    public partial class fix3103211312 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Container_ContainerCategory_ContainerCategoryId",
                table: "Container");

            migrationBuilder.DropForeignKey(
                name: "FK_Container_ContainerStatus_ContainerStatusId",
                table: "Container");

            migrationBuilder.DropForeignKey(
                name: "FK_Container_ContainerTypes_ContainerTypeId",
                table: "Container");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContainerStatus",
                table: "ContainerStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContainerCategory",
                table: "ContainerCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Container",
                table: "Container");

            migrationBuilder.RenameTable(
                name: "ContainerStatus",
                newName: "ContainerStatuses");

            migrationBuilder.RenameTable(
                name: "ContainerCategory",
                newName: "ContainerCategories");

            migrationBuilder.RenameTable(
                name: "Container",
                newName: "Containers");

            migrationBuilder.RenameIndex(
                name: "IX_Container_ContainerTypeId",
                table: "Containers",
                newName: "IX_Containers_ContainerTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Container_ContainerStatusId",
                table: "Containers",
                newName: "IX_Containers_ContainerStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Container_ContainerCategoryId",
                table: "Containers",
                newName: "IX_Containers_ContainerCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContainerStatuses",
                table: "ContainerStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContainerCategories",
                table: "ContainerCategories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Containers",
                table: "Containers",
                column: "Id");

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
                name: "Movimentations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovTypeId = table.Column<int>(type: "int", nullable: false),
                    Dt_Init = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Dt_Fin = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "IX_Movimentations_MovTypeId",
                table: "Movimentations",
                column: "MovTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_ContainerCategories_ContainerCategoryId",
                table: "Containers",
                column: "ContainerCategoryId",
                principalTable: "ContainerCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_ContainerStatuses_ContainerStatusId",
                table: "Containers",
                column: "ContainerStatusId",
                principalTable: "ContainerStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_ContainerTypes_ContainerTypeId",
                table: "Containers",
                column: "ContainerTypeId",
                principalTable: "ContainerTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Containers_ContainerCategories_ContainerCategoryId",
                table: "Containers");

            migrationBuilder.DropForeignKey(
                name: "FK_Containers_ContainerStatuses_ContainerStatusId",
                table: "Containers");

            migrationBuilder.DropForeignKey(
                name: "FK_Containers_ContainerTypes_ContainerTypeId",
                table: "Containers");

            migrationBuilder.DropTable(
                name: "Movimentations");

            migrationBuilder.DropTable(
                name: "MovType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContainerStatuses",
                table: "ContainerStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Containers",
                table: "Containers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContainerCategories",
                table: "ContainerCategories");

            migrationBuilder.RenameTable(
                name: "ContainerStatuses",
                newName: "ContainerStatus");

            migrationBuilder.RenameTable(
                name: "Containers",
                newName: "Container");

            migrationBuilder.RenameTable(
                name: "ContainerCategories",
                newName: "ContainerCategory");

            migrationBuilder.RenameIndex(
                name: "IX_Containers_ContainerTypeId",
                table: "Container",
                newName: "IX_Container_ContainerTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Containers_ContainerStatusId",
                table: "Container",
                newName: "IX_Container_ContainerStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Containers_ContainerCategoryId",
                table: "Container",
                newName: "IX_Container_ContainerCategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContainerStatus",
                table: "ContainerStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Container",
                table: "Container",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContainerCategory",
                table: "ContainerCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Container_ContainerCategory_ContainerCategoryId",
                table: "Container",
                column: "ContainerCategoryId",
                principalTable: "ContainerCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Container_ContainerStatus_ContainerStatusId",
                table: "Container",
                column: "ContainerStatusId",
                principalTable: "ContainerStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Container_ContainerTypes_ContainerTypeId",
                table: "Container",
                column: "ContainerTypeId",
                principalTable: "ContainerTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
