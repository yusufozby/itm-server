using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITM_Server.Migrations
{
    /// <inheritdoc />
    public partial class thirdCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StyleId",
                table: "Varyants");

            migrationBuilder.DropColumn(
                name: "VaryantId",
                table: "Varyants");

            migrationBuilder.RenameColumn(
                name: "styleId",
                table: "LineTotalQualities",
                newName: "styleVaryantId");

            migrationBuilder.AddColumn<string>(
                name: "VaryantCode",
                table: "Varyants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VaryantDescription",
                table: "Varyants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "VaryantName",
                table: "Varyants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StyleId = table.Column<int>(type: "int", nullable: false),
                    DeadLineDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    OrderNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LineId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StyleVaryants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StyleId = table.Column<int>(type: "int", nullable: false),
                    VaryantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StyleVaryants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StyleVaryants_Varyants_VaryantId",
                        column: x => x.VaryantId,
                        principalTable: "Varyants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderPlans_OrderId",
                table: "OrderPlans",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_LineTotalQualities_styleVaryantId",
                table: "LineTotalQualities",
                column: "styleVaryantId");

            migrationBuilder.CreateIndex(
                name: "IX_StyleVaryants_VaryantId",
                table: "StyleVaryants",
                column: "VaryantId");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LineTotalQualities_StyleVaryants_styleVaryantId",
                table: "LineTotalQualities");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderPlans_Orders_OrderId",
                table: "OrderPlans");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "StyleVaryants");

            migrationBuilder.DropIndex(
                name: "IX_OrderPlans_OrderId",
                table: "OrderPlans");

            migrationBuilder.DropIndex(
                name: "IX_LineTotalQualities_styleVaryantId",
                table: "LineTotalQualities");

            migrationBuilder.DropColumn(
                name: "VaryantCode",
                table: "Varyants");

            migrationBuilder.DropColumn(
                name: "VaryantDescription",
                table: "Varyants");

            migrationBuilder.DropColumn(
                name: "VaryantName",
                table: "Varyants");

            migrationBuilder.RenameColumn(
                name: "styleVaryantId",
                table: "LineTotalQualities",
                newName: "styleId");

            migrationBuilder.AddColumn<int>(
                name: "StyleId",
                table: "Varyants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VaryantId",
                table: "Varyants",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
