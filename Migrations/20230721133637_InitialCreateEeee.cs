using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ITM_Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateEeee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Users_UserId",
                table: "Operations");

            migrationBuilder.DropForeignKey(
                name: "FK_Repairs_Operations_OperationId",
                table: "Repairs");

            migrationBuilder.DropTable(
                name: "SecondQualities");

            migrationBuilder.DropIndex(
                name: "IX_Repairs_OperationId",
                table: "Repairs");

            migrationBuilder.DropIndex(
                name: "IX_Operations_UserId",
                table: "Operations");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OperationId",
                table: "Repairs");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Users",
                newName: "RFIDCardNo");

            migrationBuilder.RenameColumn(
                name: "LineId",
                table: "Users",
                newName: "TypeId");

            migrationBuilder.RenameColumn(
                name: "Qty",
                table: "Repairs",
                newName: "GroupCodeId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Repairs",
                newName: "GroupName");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Operations",
                newName: "TypeID");

            migrationBuilder.RenameColumn(
                name: "TargetQty",
                table: "Operations",
                newName: "OperationTimeSpeed");

            migrationBuilder.RenameColumn(
                name: "Size",
                table: "Operations",
                newName: "Tolerance");

            migrationBuilder.RenameColumn(
                name: "Qty",
                table: "Operations",
                newName: "OperationTime");

            migrationBuilder.RenameColumn(
                name: "ProducedQty",
                table: "Operations",
                newName: "MachineId");

            migrationBuilder.RenameColumn(
                name: "OperationName",
                table: "Operations",
                newName: "ReferansCode");

            migrationBuilder.RenameColumn(
                name: "ModelName",
                table: "Operations",
                newName: "OperationImage");

            migrationBuilder.RenameColumn(
                name: "ModelImage",
                table: "Operations",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FirstQuality",
                table: "Operations",
                newName: "GroupId");

            migrationBuilder.RenameColumn(
                name: "Color",
                table: "Operations",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "ActivationCode",
                table: "Operations",
                newName: "DepartmentId");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "IdentityNo",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NameSurname",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RecordNo",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isWork",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "GroupDescription",
                table: "Repairs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AparatID",
                table: "Operations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Code",
                table: "Operations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "GroupCodes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupCodeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupCodeDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupCodes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LineTotalQualities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LineId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    createTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    styleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineTotalQualities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LineTotalQualities_Repairs_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Repairs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OperationActivations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LineId = table.Column<int>(type: "int", nullable: false),
                    OperationId = table.Column<int>(type: "int", nullable: false),
                    ActivationCode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationActivations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OperationActivations_Operations_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    StyleId = table.Column<int>(type: "int", nullable: false),
                    LineId = table.Column<int>(type: "int", nullable: false),
                    RealStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RealEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isArchived = table.Column<bool>(type: "bit", nullable: false),
                    PlanQuantity = table.Column<int>(type: "int", nullable: false),
                    RealQuantity = table.Column<int>(type: "int", nullable: false),
                    OrderSequence = table.Column<int>(type: "int", nullable: false),
                    isLcd = table.Column<bool>(type: "bit", nullable: false),
                    WorkerCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Varyants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StyleId = table.Column<int>(type: "int", nullable: false),
                    VaryantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Varyants", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Repairs_GroupCodeId",
                table: "Repairs",
                column: "GroupCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_GroupId",
                table: "Operations",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_LineTotalQualities_GroupId",
                table: "LineTotalQualities",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_OperationActivations_OperationId",
                table: "OperationActivations",
                column: "OperationId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Operations_Repairs_GroupId",
                table: "Operations");

            migrationBuilder.DropForeignKey(
                name: "FK_Repairs_GroupCodes_GroupCodeId",
                table: "Repairs");

            migrationBuilder.DropTable(
                name: "GroupCodes");

            migrationBuilder.DropTable(
                name: "LineTotalQualities");

            migrationBuilder.DropTable(
                name: "OperationActivations");

            migrationBuilder.DropTable(
                name: "OrderPlans");

            migrationBuilder.DropTable(
                name: "Varyants");

            migrationBuilder.DropIndex(
                name: "IX_Repairs_GroupCodeId",
                table: "Repairs");

            migrationBuilder.DropIndex(
                name: "IX_Operations_GroupId",
                table: "Operations");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "IdentityNo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NameSurname",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RecordNo",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "isWork",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "GroupDescription",
                table: "Repairs");

            migrationBuilder.DropColumn(
                name: "AparatID",
                table: "Operations");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Operations");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "TypeId",
                table: "Users",
                newName: "LineId");

            migrationBuilder.RenameColumn(
                name: "RFIDCardNo",
                table: "Users",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "GroupName",
                table: "Repairs",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "GroupCodeId",
                table: "Repairs",
                newName: "Qty");

            migrationBuilder.RenameColumn(
                name: "TypeID",
                table: "Operations",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Tolerance",
                table: "Operations",
                newName: "Size");

            migrationBuilder.RenameColumn(
                name: "ReferansCode",
                table: "Operations",
                newName: "OperationName");

            migrationBuilder.RenameColumn(
                name: "OperationTimeSpeed",
                table: "Operations",
                newName: "TargetQty");

            migrationBuilder.RenameColumn(
                name: "OperationTime",
                table: "Operations",
                newName: "Qty");

            migrationBuilder.RenameColumn(
                name: "OperationImage",
                table: "Operations",
                newName: "ModelName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Operations",
                newName: "ModelImage");

            migrationBuilder.RenameColumn(
                name: "MachineId",
                table: "Operations",
                newName: "ProducedQty");

            migrationBuilder.RenameColumn(
                name: "GroupId",
                table: "Operations",
                newName: "FirstQuality");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Operations",
                newName: "Color");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Operations",
                newName: "ActivationCode");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "OperationId",
                table: "Repairs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SecondQualities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OperationId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondQualities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecondQualities_Operations_OperationId",
                        column: x => x.OperationId,
                        principalTable: "Operations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Repairs_OperationId",
                table: "Repairs",
                column: "OperationId");

            migrationBuilder.CreateIndex(
                name: "IX_Operations_UserId",
                table: "Operations",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SecondQualities_OperationId",
                table: "SecondQualities",
                column: "OperationId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Operations_Users_UserId",
                table: "Operations",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Repairs_Operations_OperationId",
                table: "Repairs",
                column: "OperationId",
                principalTable: "Operations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
