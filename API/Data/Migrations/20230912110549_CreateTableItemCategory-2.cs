using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableItemCategory2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemCategories_ItemCategoryId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemCategories",
                table: "ItemCategories");

            migrationBuilder.RenameTable(
                name: "ItemCategories",
                newName: "ItemCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemCategory",
                table: "ItemCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemCategory_ItemCategoryId",
                table: "Items",
                column: "ItemCategoryId",
                principalTable: "ItemCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemCategory_ItemCategoryId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemCategory",
                table: "ItemCategory");

            migrationBuilder.RenameTable(
                name: "ItemCategory",
                newName: "ItemCategories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemCategories",
                table: "ItemCategories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemCategories_ItemCategoryId",
                table: "Items",
                column: "ItemCategoryId",
                principalTable: "ItemCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
