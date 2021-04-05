using Microsoft.EntityFrameworkCore.Migrations;

namespace MovContainer.Migrations
{
    public partial class fix11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentations_MovType_Type_MovId",
                table: "Movimentations");

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

            migrationBuilder.AddColumn<int>(
                name: "MovTypeId",
                table: "Movimentations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContainerCategoryId",
                table: "Containers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContainerStatusId",
                table: "Containers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContainerTypeId",
                table: "Containers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movimentations_MovTypeId",
                table: "Movimentations",
                column: "MovTypeId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentations_MovType_MovTypeId",
                table: "Movimentations",
                column: "MovTypeId",
                principalTable: "MovType",
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

            migrationBuilder.DropForeignKey(
                name: "FK_Movimentations_MovType_MovTypeId",
                table: "Movimentations");

            migrationBuilder.DropIndex(
                name: "IX_Movimentations_MovTypeId",
                table: "Movimentations");

            migrationBuilder.DropIndex(
                name: "IX_Containers_ContainerCategoryId",
                table: "Containers");

            migrationBuilder.DropIndex(
                name: "IX_Containers_ContainerStatusId",
                table: "Containers");

            migrationBuilder.DropIndex(
                name: "IX_Containers_ContainerTypeId",
                table: "Containers");

            migrationBuilder.DropColumn(
                name: "MovTypeId",
                table: "Movimentations");

            migrationBuilder.DropColumn(
                name: "ContainerCategoryId",
                table: "Containers");

            migrationBuilder.DropColumn(
                name: "ContainerStatusId",
                table: "Containers");

            migrationBuilder.DropColumn(
                name: "ContainerTypeId",
                table: "Containers");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentations_MovType_Type_MovId",
                table: "Movimentations",
                column: "Type_MovId",
                principalTable: "MovType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
