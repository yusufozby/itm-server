using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITM_Server.Migrations
{
    /// <inheritdoc />
    public partial class _20create : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "LineTotalQualities",
                newName: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_LineTotalQualities_EmployeeId",
                table: "LineTotalQualities",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_LineTotalQualities_Employees_EmployeeId",
                table: "LineTotalQualities",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LineTotalQualities_Employees_EmployeeId",
                table: "LineTotalQualities");

            migrationBuilder.DropIndex(
                name: "IX_LineTotalQualities_EmployeeId",
                table: "LineTotalQualities");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "LineTotalQualities",
                newName: "Quantity");
        }
    }
}
