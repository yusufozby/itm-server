using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITM_Server.Migrations
{
    /// <inheritdoc />
    public partial class thirdCreateee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LineTotalQualities_StyleVaryants_styleVaryantId",
                table: "LineTotalQualities");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderPlans_Orders_OrderId",
                table: "OrderPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_StyleVaryants_Varyants_VaryantId",
                table: "StyleVaryants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Varyants",
                table: "Varyants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StyleVaryants",
                table: "StyleVaryants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.RenameTable(
                name: "Varyants",
                newName: "Varyant");

            migrationBuilder.RenameTable(
                name: "StyleVaryants",
                newName: "StyleVaryant");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameIndex(
                name: "IX_StyleVaryants_VaryantId",
                table: "StyleVaryant",
                newName: "IX_StyleVaryant_VaryantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Varyant",
                table: "Varyant",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StyleVaryant",
                table: "StyleVaryant",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LineTotalQualities_StyleVaryant_styleVaryantId",
                table: "LineTotalQualities",
                column: "styleVaryantId",
                principalTable: "StyleVaryant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPlans_Order_OrderId",
                table: "OrderPlans",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StyleVaryant_Varyant_VaryantId",
                table: "StyleVaryant",
                column: "VaryantId",
                principalTable: "Varyant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LineTotalQualities_StyleVaryant_styleVaryantId",
                table: "LineTotalQualities");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderPlans_Order_OrderId",
                table: "OrderPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_StyleVaryant_Varyant_VaryantId",
                table: "StyleVaryant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Varyant",
                table: "Varyant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StyleVaryant",
                table: "StyleVaryant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.RenameTable(
                name: "Varyant",
                newName: "Varyants");

            migrationBuilder.RenameTable(
                name: "StyleVaryant",
                newName: "StyleVaryants");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameIndex(
                name: "IX_StyleVaryant_VaryantId",
                table: "StyleVaryants",
                newName: "IX_StyleVaryants_VaryantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Varyants",
                table: "Varyants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StyleVaryants",
                table: "StyleVaryants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LineTotalQualities_StyleVaryants_styleVaryantId",
                table: "LineTotalQualities",
                column: "styleVaryantId",
                principalTable: "StyleVaryants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderPlans_Orders_OrderId",
                table: "OrderPlans",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StyleVaryants_Varyants_VaryantId",
                table: "StyleVaryants",
                column: "VaryantId",
                principalTable: "Varyants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
