using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class unitofmeasureIdFK2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_UnitOfMeasures_UnitOfMeasureId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "UnitOfMeasureId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_UnitOfMeasures_UnitOfMeasureId",
                table: "Items",
                column: "UnitOfMeasureId",
                principalTable: "UnitOfMeasures",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_UnitOfMeasures_UnitOfMeasureId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "UnitOfMeasureId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_UnitOfMeasures_UnitOfMeasureId",
                table: "Items",
                column: "UnitOfMeasureId",
                principalTable: "UnitOfMeasures",
                principalColumn: "Id");
        }
    }
}
