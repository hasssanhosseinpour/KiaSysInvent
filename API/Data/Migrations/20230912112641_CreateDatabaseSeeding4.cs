using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabaseSeeding4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemCategory_ItemCategoryId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "ItemCategory");

            migrationBuilder.RenameColumn(
                name: "ItemCategoryId",
                table: "Items",
                newName: "CategoryItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_ItemCategoryId",
                table: "Items",
                newName: "IX_Items_CategoryItemId");

            migrationBuilder.CreateTable(
                name: "CategoryItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryItems", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Items_CategoryItems_CategoryItemId",
                table: "Items",
                column: "CategoryItemId",
                principalTable: "CategoryItems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_CategoryItems_CategoryItemId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "CategoryItems");

            migrationBuilder.RenameColumn(
                name: "CategoryItemId",
                table: "Items",
                newName: "ItemCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_CategoryItemId",
                table: "Items",
                newName: "IX_Items_ItemCategoryId");

            migrationBuilder.CreateTable(
                name: "ItemCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemCategory", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemCategory_ItemCategoryId",
                table: "Items",
                column: "ItemCategoryId",
                principalTable: "ItemCategory",
                principalColumn: "Id");
        }
    }
}
