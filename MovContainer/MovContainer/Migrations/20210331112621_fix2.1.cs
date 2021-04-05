using Microsoft.EntityFrameworkCore.Migrations;

namespace MovContainer.Migrations
{
    public partial class fix21 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContainerType",
                table: "ContainerType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContainerStatus",
                table: "ContainerStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContainerCategory",
                table: "ContainerCategory");

            migrationBuilder.RenameTable(
                name: "ContainerType",
                newName: "ContainerTypes");

            migrationBuilder.RenameTable(
                name: "ContainerStatus",
                newName: "ContainerStatuses");

            migrationBuilder.RenameTable(
                name: "ContainerCategory",
                newName: "ContainerCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContainerTypes",
                table: "ContainerTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContainerStatuses",
                table: "ContainerStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContainerCategories",
                table: "ContainerCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_ContainerCategories_CategoryId",
                table: "Containers",
                column: "CategoryId",
                principalTable: "ContainerCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_ContainerStatuses_StatusId",
                table: "Containers",
                column: "StatusId",
                principalTable: "ContainerStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Containers_ContainerTypes_TypeId",
                table: "Containers",
                column: "TypeId",
                principalTable: "ContainerTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Containers_ContainerCategories_CategoryId",
                table: "Containers");

            migrationBuilder.DropForeignKey(
                name: "FK_Containers_ContainerStatuses_StatusId",
                table: "Containers");

            migrationBuilder.DropForeignKey(
                name: "FK_Containers_ContainerTypes_TypeId",
                table: "Containers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContainerTypes",
                table: "ContainerTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContainerStatuses",
                table: "ContainerStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContainerCategories",
                table: "ContainerCategories");

            migrationBuilder.RenameTable(
                name: "ContainerTypes",
                newName: "ContainerType");

            migrationBuilder.RenameTable(
                name: "ContainerStatuses",
                newName: "ContainerStatus");

            migrationBuilder.RenameTable(
                name: "ContainerCategories",
                newName: "ContainerCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContainerType",
                table: "ContainerType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContainerStatus",
                table: "ContainerStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContainerCategory",
                table: "ContainerCategory",
                column: "Id");

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
        }
    }
}
