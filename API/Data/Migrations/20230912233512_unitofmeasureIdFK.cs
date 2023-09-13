using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class unitofmeasureIdFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnitOfMeasureId",
                table: "Items",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Items_UnitOfMeasureId",
                table: "Items",
                column: "UnitOfMeasureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_UnitOfMeasures_UnitOfMeasureId",
                table: "Items",
                column: "UnitOfMeasureId",
                principalTable: "UnitOfMeasures",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_UnitOfMeasures_UnitOfMeasureId",
                table: "Items");

            migrationBuilder.DropIndex(
                name: "IX_Items_UnitOfMeasureId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "UnitOfMeasureId",
                table: "Items");
        }
    }
}
