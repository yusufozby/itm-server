using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITM_Server.Migrations
{
    /// <inheritdoc />
    public partial class secondCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LineTotalQualities_Repairs_GroupId",
                table: "LineTotalQualities");

            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Repairs_GroupId",
                table: "Operations");

            migrationBuilder.DropForeignKey(
                name: "FK_Repairs_GroupCodes_GroupCodeId",
                table: "Repairs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Repairs",
                table: "Repairs");

            migrationBuilder.RenameTable(
                name: "Repairs",
                newName: "Groups");

            migrationBuilder.RenameIndex(
                name: "IX_Repairs_GroupCodeId",
                table: "Groups",
                newName: "IX_Groups_GroupCodeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Groups",
                table: "Groups",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_GroupCodes_GroupCodeId",
                table: "Groups",
                column: "GroupCodeId",
                principalTable: "GroupCodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LineTotalQualities_Groups_GroupId",
                table: "LineTotalQualities",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Groups_GroupId",
                table: "Operations",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_GroupCodes_GroupCodeId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_LineTotalQualities_Groups_GroupId",
                table: "LineTotalQualities");

            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Groups_GroupId",
                table: "Operations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Groups",
                table: "Groups");

            migrationBuilder.RenameTable(
                name: "Groups",
                newName: "Repairs");

            migrationBuilder.RenameIndex(
                name: "IX_Groups_GroupCodeId",
                table: "Repairs",
                newName: "IX_Repairs_GroupCodeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Repairs",
                table: "Repairs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LineTotalQualities_Repairs_GroupId",
                table: "LineTotalQualities",
                column: "GroupId",
                principalTable: "Repairs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Repairs_GroupId",
                table: "Operations",
                column: "GroupId",
                principalTable: "Repairs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Repairs_GroupCodes_GroupCodeId",
                table: "Repairs",
                column: "GroupCodeId",
                principalTable: "GroupCodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
