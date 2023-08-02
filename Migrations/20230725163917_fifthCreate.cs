using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITM_Server.Migrations
{
    /// <inheritdoc />
    public partial class fifthCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Groups_GroupId",
                table: "Operations");

            migrationBuilder.DropTable(
                name: "OrderPlans");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Operations_GroupId",
                table: "Operations");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "LineTotalQualities");

            migrationBuilder.AddColumn<int>(
                name: "styleId",
                table: "OperationActivations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Quality",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Employee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    styleVaryantId = table.Column<int>(type: "int", nullable: false),
                    QualityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quality", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quality_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Quality_Quality_QualityId",
                        column: x => x.QualityId,
                        principalTable: "Quality",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Quality_StyleVaryants_styleVaryantId",
                        column: x => x.styleVaryantId,
                        principalTable: "StyleVaryants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Style",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferanceNo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    modelGroupID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    SeasonGroupId = table.Column<int>(type: "int", nullable: false),
                    KatalogGroupId = table.Column<int>(type: "int", nullable: false),
                    SetGroupId = table.Column<int>(type: "int", nullable: false),
                    CostingPeriodId = table.Column<int>(type: "int", nullable: false),
                    StyleRouteId = table.Column<int>(type: "int", nullable: false),
                    isArchived = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Style", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StyleVaryants_StyleId",
                table: "StyleVaryants",
                column: "StyleId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationActivations_styleId",
                table: "OperationActivations",
                column: "styleId");

            migrationBuilder.CreateIndex(
                name: "IX_Quality_GroupId",
                table: "Quality",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Quality_QualityId",
                table: "Quality",
                column: "QualityId");

            migrationBuilder.CreateIndex(
                name: "IX_Quality_styleVaryantId",
                table: "Quality",
                column: "styleVaryantId");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationActivations_Style_styleId",
                table: "OperationActivations",
                column: "styleId",
                principalTable: "Style",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StyleVaryants_Style_StyleId",
                table: "StyleVaryants",
                column: "StyleId",
                principalTable: "Style",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperationActivations_Style_styleId",
                table: "OperationActivations");

            migrationBuilder.DropForeignKey(
                name: "FK_StyleVaryants_Style_StyleId",
                table: "StyleVaryants");

            migrationBuilder.DropTable(
                name: "Quality");

            migrationBuilder.DropTable(
                name: "Style");

            migrationBuilder.DropIndex(
                name: "IX_StyleVaryants_StyleId",
                table: "StyleVaryants");

            migrationBuilder.DropIndex(
                name: "IX_OperationActivations_styleId",
                table: "OperationActivations");

            migrationBuilder.DropColumn(
                name: "styleId",
                table: "OperationActivations");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "LineTotalQualities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeadLineDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsArchived = table.Column<bool>(type: "bit", nullable: false),
                    LineId = table.Column<int>(type: "int", nullable: false),
                    OrderNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StyleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    LineId = table.Column<int>(type: "int", nullable: false),
                    OrderSequence = table.Column<int>(type: "int", nullable: false),
                    PlanQuantity = table.Column<int>(type: "int", nullable: false),
                    RealEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RealQuantity = table.Column<int>(type: "int", nullable: false),
                    RealStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StyleId = table.Column<int>(type: "int", nullable: false),
                    WorkerCount = table.Column<int>(type: "int", nullable: false),
                    isArchived = table.Column<bool>(type: "bit", nullable: false),
                    isLcd = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderPlans_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Operations_GroupId",
                table: "Operations",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderPlans_OrderId",
                table: "OrderPlans",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Groups_GroupId",
                table: "Operations",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
