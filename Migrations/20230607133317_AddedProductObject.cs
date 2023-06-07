using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Restaurant.Migrations
{
    /// <inheritdoc />
    public partial class AddedProductObject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "OrderModelId",
                table: "Menu",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Menu_OrderModelId",
                table: "Menu",
                column: "OrderModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menu_Orders_OrderModelId",
                table: "Menu",
                column: "OrderModelId",
                principalTable: "Orders",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menu_Orders_OrderModelId",
                table: "Menu");

            migrationBuilder.DropIndex(
                name: "IX_Menu_OrderModelId",
                table: "Menu");

            migrationBuilder.DropColumn(
                name: "OrderModelId",
                table: "Menu");

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Orders",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
