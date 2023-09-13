using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableItemCategory3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemCategory_ItemCategoryId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "ItemCategoryId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 50);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemCategory_ItemCategoryId",
                table: "Items",
                column: "ItemCategoryId",
                principalTable: "ItemCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemCategory_ItemCategoryId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "ItemCategoryId",
                table: "Items",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemCategory_ItemCategoryId",
                table: "Items",
                column: "ItemCategoryId",
                principalTable: "ItemCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
