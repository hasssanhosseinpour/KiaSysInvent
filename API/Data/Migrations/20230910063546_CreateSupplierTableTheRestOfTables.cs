using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateSupplierTableTheRestOfTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Supplier_SupplierID",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "Item");

            migrationBuilder.RenameIndex(
                name: "IX_Items_SupplierID",
                table: "Item",
                newName: "IX_Item_SupplierID");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Supplier",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserID",
                table: "Supplier",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Supplier",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Supplier",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedUserID",
                table: "Supplier",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Item",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedUserID",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Item",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Item",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdatedUserID",
                table: "Item",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Item",
                table: "Item",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Supplier_SupplierID",
                table: "Item",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Item_Supplier_SupplierID",
                table: "Item");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Item",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "CreatedUserID",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "UpdatedUserID",
                table: "Supplier");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "CreatedUserID",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "UpdatedUserID",
                table: "Item");

            migrationBuilder.RenameTable(
                name: "Item",
                newName: "Items");

            migrationBuilder.RenameIndex(
                name: "IX_Item_SupplierID",
                table: "Items",
                newName: "IX_Items_SupplierID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Supplier_SupplierID",
                table: "Items",
                column: "SupplierID",
                principalTable: "Supplier",
                principalColumn: "Id");
        }
    }
}
