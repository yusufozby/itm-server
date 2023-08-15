using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITM_Server.Migrations
{
    /// <inheritdoc />
    public partial class eightthCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Qualities_Qualities_QualityId",
                table: "Qualities");

            migrationBuilder.DropIndex(
                name: "IX_Qualities_QualityId",
                table: "Qualities");

            migrationBuilder.DropColumn(
                name: "QualityId",
                table: "Qualities");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QualityId",
                table: "Qualities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Qualities_QualityId",
                table: "Qualities",
                column: "QualityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Qualities_Qualities_QualityId",
                table: "Qualities",
                column: "QualityId",
                principalTable: "Qualities",
                principalColumn: "Id");
        }
    }
}
