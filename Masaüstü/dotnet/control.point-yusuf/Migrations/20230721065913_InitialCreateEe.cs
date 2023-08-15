using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITM_Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateEe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LineId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LineId",
                table: "Users");
        }
    }
}
