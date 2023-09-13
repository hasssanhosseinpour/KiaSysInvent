using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableItemCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Items");

            migrationBuilder.AddColumn<int>(
                name: "ItemCategoryId",
                table: "Items",
                type: "int",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ItemCategories",
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
                    table.PrimaryKey("PK_ItemCategories", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_ItemCategoryId",
                table: "Items",
                column: "ItemCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_ItemCategories_ItemCategoryId",
                table: "Items",
                column: "ItemCategoryId",
                principalTable: "ItemCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_ItemCategories_ItemCategoryId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "ItemCategories");

            migrationBuilder.DropIndex(
                name: "IX_Items_ItemCategoryId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemCategoryId",
                table: "Items");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Items",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
