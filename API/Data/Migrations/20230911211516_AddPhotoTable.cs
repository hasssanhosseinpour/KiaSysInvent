using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPhotoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BOMs_Items_ItemID",
                table: "BOMs");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryTransactions_Items_ItemID",
                table: "InventoryTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Suppliers_SupplierID",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Items_ItemID",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderID",
                table: "OrderItems");

            migrationBuilder.RenameColumn(
                name: "UpdatedUserID",
                table: "UnitOfMeasures",
                newName: "UpdatedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUserID",
                table: "UnitOfMeasures",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "UpdatedUserID",
                table: "Suppliers",
                newName: "UpdatedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUserID",
                table: "Suppliers",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "UpdatedUserID",
                table: "Orders",
                newName: "UpdatedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUserID",
                table: "Orders",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "UpdatedUserID",
                table: "OrderItems",
                newName: "UpdatedUserId");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "OrderItems",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "ItemID",
                table: "OrderItems",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "CreatedUserID",
                table: "OrderItems",
                newName: "CreatedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderID",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_ItemID",
                table: "OrderItems",
                newName: "IX_OrderItems_ItemId");

            migrationBuilder.RenameColumn(
                name: "UpdatedUserID",
                table: "Items",
                newName: "UpdatedUserId");

            migrationBuilder.RenameColumn(
                name: "SupplierID",
                table: "Items",
                newName: "SupplierId");

            migrationBuilder.RenameColumn(
                name: "CreatedUserID",
                table: "Items",
                newName: "CreatedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_SupplierID",
                table: "Items",
                newName: "IX_Items_SupplierId");

            migrationBuilder.RenameColumn(
                name: "UpdatedUserID",
                table: "InventoryTransactions",
                newName: "UpdatedUserId");

            migrationBuilder.RenameColumn(
                name: "ItemID",
                table: "InventoryTransactions",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "CreatedUserID",
                table: "InventoryTransactions",
                newName: "CreatedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_InventoryTransactions_ItemID",
                table: "InventoryTransactions",
                newName: "IX_InventoryTransactions_ItemId");

            migrationBuilder.RenameColumn(
                name: "UpdatedUserID",
                table: "Customers",
                newName: "UpdatedUserId");

            migrationBuilder.RenameColumn(
                name: "CreatedUserID",
                table: "Customers",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "UpdatedUserID",
                table: "BOMs",
                newName: "UpdatedUserId");

            migrationBuilder.RenameColumn(
                name: "ItemID",
                table: "BOMs",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "CreatedUserID",
                table: "BOMs",
                newName: "CreatedUserId");

            migrationBuilder.RenameColumn(
                name: "ChildItemID",
                table: "BOMs",
                newName: "ChildItemId");

            migrationBuilder.RenameIndex(
                name: "IX_BOMs_ItemID",
                table: "BOMs",
                newName: "IX_BOMs_ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_BOMs_Items_ItemId",
                table: "BOMs",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryTransactions_Items_ItemId",
                table: "InventoryTransactions",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Suppliers_SupplierId",
                table: "Items",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Items_ItemId",
                table: "OrderItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BOMs_Items_ItemId",
                table: "BOMs");

            migrationBuilder.DropForeignKey(
                name: "FK_InventoryTransactions_Items_ItemId",
                table: "InventoryTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Suppliers_SupplierId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Items_ItemId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.RenameColumn(
                name: "UpdatedUserId",
                table: "UnitOfMeasures",
                newName: "UpdatedUserID");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "UnitOfMeasures",
                newName: "CreatedUserID");

            migrationBuilder.RenameColumn(
                name: "UpdatedUserId",
                table: "Suppliers",
                newName: "UpdatedUserID");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "Suppliers",
                newName: "CreatedUserID");

            migrationBuilder.RenameColumn(
                name: "UpdatedUserId",
                table: "Orders",
                newName: "UpdatedUserID");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "Orders",
                newName: "CreatedUserID");

            migrationBuilder.RenameColumn(
                name: "UpdatedUserId",
                table: "OrderItems",
                newName: "UpdatedUserID");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "OrderItems",
                newName: "OrderID");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "OrderItems",
                newName: "ItemID");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "OrderItems",
                newName: "CreatedUserID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderID");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_ItemId",
                table: "OrderItems",
                newName: "IX_OrderItems_ItemID");

            migrationBuilder.RenameColumn(
                name: "UpdatedUserId",
                table: "Items",
                newName: "UpdatedUserID");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "Items",
                newName: "SupplierID");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "Items",
                newName: "CreatedUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Items_SupplierId",
                table: "Items",
                newName: "IX_Items_SupplierID");

            migrationBuilder.RenameColumn(
                name: "UpdatedUserId",
                table: "InventoryTransactions",
                newName: "UpdatedUserID");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "InventoryTransactions",
                newName: "ItemID");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "InventoryTransactions",
                newName: "CreatedUserID");

            migrationBuilder.RenameIndex(
                name: "IX_InventoryTransactions_ItemId",
                table: "InventoryTransactions",
                newName: "IX_InventoryTransactions_ItemID");

            migrationBuilder.RenameColumn(
                name: "UpdatedUserId",
                table: "Customers",
                newName: "UpdatedUserID");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "Customers",
                newName: "CreatedUserID");

            migrationBuilder.RenameColumn(
                name: "UpdatedUserId",
                table: "BOMs",
                newName: "UpdatedUserID");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "BOMs",
                newName: "ItemID");

            migrationBuilder.RenameColumn(
                name: "CreatedUserId",
                table: "BOMs",
                newName: "CreatedUserID");

            migrationBuilder.RenameColumn(
                name: "ChildItemId",
                table: "BOMs",
                newName: "ChildItemID");

            migrationBuilder.RenameIndex(
                name: "IX_BOMs_ItemId",
                table: "BOMs",
                newName: "IX_BOMs_ItemID");

            migrationBuilder.AddForeignKey(
                name: "FK_BOMs_Items_ItemID",
                table: "BOMs",
                column: "ItemID",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryTransactions_Items_ItemID",
                table: "InventoryTransactions",
                column: "ItemID",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Suppliers_SupplierID",
                table: "Items",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Items_ItemID",
                table: "OrderItems",
                column: "ItemID",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderID",
                table: "OrderItems",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
