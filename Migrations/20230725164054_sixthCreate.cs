using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITM_Server.Migrations
{
    /// <inheritdoc />
    public partial class sixthCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperationActivations_Style_styleId",
                table: "OperationActivations");

            migrationBuilder.DropForeignKey(
                name: "FK_Quality_Groups_GroupId",
                table: "Quality");

            migrationBuilder.DropForeignKey(
                name: "FK_Quality_Quality_QualityId",
                table: "Quality");

            migrationBuilder.DropForeignKey(
                name: "FK_Quality_StyleVaryants_styleVaryantId",
                table: "Quality");

            migrationBuilder.DropForeignKey(
                name: "FK_StyleVaryants_Style_StyleId",
                table: "StyleVaryants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Style",
                table: "Style");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Quality",
                table: "Quality");

            migrationBuilder.RenameTable(
                name: "Style",
                newName: "Styles");

            migrationBuilder.RenameTable(
                name: "Quality",
                newName: "Qualities");

            migrationBuilder.RenameIndex(
                name: "IX_Quality_styleVaryantId",
                table: "Qualities",
                newName: "IX_Qualities_styleVaryantId");

            migrationBuilder.RenameIndex(
                name: "IX_Quality_QualityId",
                table: "Qualities",
                newName: "IX_Qualities_QualityId");

            migrationBuilder.RenameIndex(
                name: "IX_Quality_GroupId",
                table: "Qualities",
                newName: "IX_Qualities_GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Styles",
                table: "Styles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Qualities",
                table: "Qualities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationActivations_Styles_styleId",
                table: "OperationActivations",
                column: "styleId",
                principalTable: "Styles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualities_Groups_GroupId",
                table: "Qualities",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Qualities_Qualities_QualityId",
                table: "Qualities",
                column: "QualityId",
                principalTable: "Qualities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Qualities_StyleVaryants_styleVaryantId",
                table: "Qualities",
                column: "styleVaryantId",
                principalTable: "StyleVaryants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StyleVaryants_Styles_StyleId",
                table: "StyleVaryants",
                column: "StyleId",
                principalTable: "Styles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OperationActivations_Styles_styleId",
                table: "OperationActivations");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualities_Groups_GroupId",
                table: "Qualities");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualities_Qualities_QualityId",
                table: "Qualities");

            migrationBuilder.DropForeignKey(
                name: "FK_Qualities_StyleVaryants_styleVaryantId",
                table: "Qualities");

            migrationBuilder.DropForeignKey(
                name: "FK_StyleVaryants_Styles_StyleId",
                table: "StyleVaryants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Styles",
                table: "Styles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Qualities",
                table: "Qualities");

            migrationBuilder.RenameTable(
                name: "Styles",
                newName: "Style");

            migrationBuilder.RenameTable(
                name: "Qualities",
                newName: "Quality");

            migrationBuilder.RenameIndex(
                name: "IX_Qualities_styleVaryantId",
                table: "Quality",
                newName: "IX_Quality_styleVaryantId");

            migrationBuilder.RenameIndex(
                name: "IX_Qualities_QualityId",
                table: "Quality",
                newName: "IX_Quality_QualityId");

            migrationBuilder.RenameIndex(
                name: "IX_Qualities_GroupId",
                table: "Quality",
                newName: "IX_Quality_GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Style",
                table: "Style",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quality",
                table: "Quality",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OperationActivations_Style_styleId",
                table: "OperationActivations",
                column: "styleId",
                principalTable: "Style",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quality_Groups_GroupId",
                table: "Quality",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quality_Quality_QualityId",
                table: "Quality",
                column: "QualityId",
                principalTable: "Quality",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Quality_StyleVaryants_styleVaryantId",
                table: "Quality",
                column: "styleVaryantId",
                principalTable: "StyleVaryants",
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
    }
}
