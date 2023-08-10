using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_Conection_Models.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PCComponents_Motherboards_MotherboardId",
                table: "PCComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_PCComponents_PCCases_PCCaseId",
                table: "PCComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_PCComponents_PowerSupplys_PowerSupplyId",
                table: "PCComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_PCComponents_Processors_ProcessorId",
                table: "PCComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_PCComponents_RAMs_RAMId",
                table: "PCComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_PCComponents_SSDM2s_SSDM2Id",
                table: "PCComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_PCComponents_VideoCards_VideoCardId",
                table: "PCComponents");

            migrationBuilder.DropIndex(
                name: "IX_PCComponents_MotherboardId",
                table: "PCComponents");

            migrationBuilder.DropIndex(
                name: "IX_PCComponents_PCCaseId",
                table: "PCComponents");

            migrationBuilder.DropIndex(
                name: "IX_PCComponents_PowerSupplyId",
                table: "PCComponents");

            migrationBuilder.DropIndex(
                name: "IX_PCComponents_ProcessorId",
                table: "PCComponents");

            migrationBuilder.DropIndex(
                name: "IX_PCComponents_RAMId",
                table: "PCComponents");

            migrationBuilder.DropIndex(
                name: "IX_PCComponents_SSDM2Id",
                table: "PCComponents");

            migrationBuilder.DropIndex(
                name: "IX_PCComponents_VideoCardId",
                table: "PCComponents");

            migrationBuilder.DropColumn(
                name: "MotherboardId",
                table: "PCComponents");

            migrationBuilder.DropColumn(
                name: "PCCaseId",
                table: "PCComponents");

            migrationBuilder.DropColumn(
                name: "PowerSupplyId",
                table: "PCComponents");

            migrationBuilder.DropColumn(
                name: "ProcessorId",
                table: "PCComponents");

            migrationBuilder.DropColumn(
                name: "RAMId",
                table: "PCComponents");

            migrationBuilder.DropColumn(
                name: "SSDM2Id",
                table: "PCComponents");

            migrationBuilder.DropColumn(
                name: "VideoCardId",
                table: "PCComponents");

            migrationBuilder.CreateIndex(
                name: "IX_PCComponents_IdMotherboard",
                table: "PCComponents",
                column: "IdMotherboard");

            migrationBuilder.CreateIndex(
                name: "IX_PCComponents_IdPCCase",
                table: "PCComponents",
                column: "IdPCCase");

            migrationBuilder.CreateIndex(
                name: "IX_PCComponents_IdPowerSupply",
                table: "PCComponents",
                column: "IdPowerSupply");

            migrationBuilder.CreateIndex(
                name: "IX_PCComponents_IdProcessor",
                table: "PCComponents",
                column: "IdProcessor");

            migrationBuilder.CreateIndex(
                name: "IX_PCComponents_IdRAM",
                table: "PCComponents",
                column: "IdRAM");

            migrationBuilder.CreateIndex(
                name: "IX_PCComponents_IdSSDM2",
                table: "PCComponents",
                column: "IdSSDM2");

            migrationBuilder.CreateIndex(
                name: "IX_PCComponents_IdVideoCard",
                table: "PCComponents",
                column: "IdVideoCard");

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_Motherboards_IdMotherboard",
                table: "PCComponents",
                column: "IdMotherboard",
                principalTable: "Motherboards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_PCCases_IdPCCase",
                table: "PCComponents",
                column: "IdPCCase",
                principalTable: "PCCases",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_PowerSupplys_IdPowerSupply",
                table: "PCComponents",
                column: "IdPowerSupply",
                principalTable: "PowerSupplys",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_Processors_IdProcessor",
                table: "PCComponents",
                column: "IdProcessor",
                principalTable: "Processors",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_RAMs_IdRAM",
                table: "PCComponents",
                column: "IdRAM",
                principalTable: "RAMs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_SSDM2s_IdSSDM2",
                table: "PCComponents",
                column: "IdSSDM2",
                principalTable: "SSDM2s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_VideoCards_IdVideoCard",
                table: "PCComponents",
                column: "IdVideoCard",
                principalTable: "VideoCards",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PCComponents_Motherboards_IdMotherboard",
                table: "PCComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_PCComponents_PCCases_IdPCCase",
                table: "PCComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_PCComponents_PowerSupplys_IdPowerSupply",
                table: "PCComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_PCComponents_Processors_IdProcessor",
                table: "PCComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_PCComponents_RAMs_IdRAM",
                table: "PCComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_PCComponents_SSDM2s_IdSSDM2",
                table: "PCComponents");

            migrationBuilder.DropForeignKey(
                name: "FK_PCComponents_VideoCards_IdVideoCard",
                table: "PCComponents");

            migrationBuilder.DropIndex(
                name: "IX_PCComponents_IdMotherboard",
                table: "PCComponents");

            migrationBuilder.DropIndex(
                name: "IX_PCComponents_IdPCCase",
                table: "PCComponents");

            migrationBuilder.DropIndex(
                name: "IX_PCComponents_IdPowerSupply",
                table: "PCComponents");

            migrationBuilder.DropIndex(
                name: "IX_PCComponents_IdProcessor",
                table: "PCComponents");

            migrationBuilder.DropIndex(
                name: "IX_PCComponents_IdRAM",
                table: "PCComponents");

            migrationBuilder.DropIndex(
                name: "IX_PCComponents_IdSSDM2",
                table: "PCComponents");

            migrationBuilder.DropIndex(
                name: "IX_PCComponents_IdVideoCard",
                table: "PCComponents");

            migrationBuilder.AddColumn<int>(
                name: "MotherboardId",
                table: "PCComponents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PCCaseId",
                table: "PCComponents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PowerSupplyId",
                table: "PCComponents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProcessorId",
                table: "PCComponents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RAMId",
                table: "PCComponents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SSDM2Id",
                table: "PCComponents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VideoCardId",
                table: "PCComponents",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PCComponents_MotherboardId",
                table: "PCComponents",
                column: "MotherboardId");

            migrationBuilder.CreateIndex(
                name: "IX_PCComponents_PCCaseId",
                table: "PCComponents",
                column: "PCCaseId");

            migrationBuilder.CreateIndex(
                name: "IX_PCComponents_PowerSupplyId",
                table: "PCComponents",
                column: "PowerSupplyId");

            migrationBuilder.CreateIndex(
                name: "IX_PCComponents_ProcessorId",
                table: "PCComponents",
                column: "ProcessorId");

            migrationBuilder.CreateIndex(
                name: "IX_PCComponents_RAMId",
                table: "PCComponents",
                column: "RAMId");

            migrationBuilder.CreateIndex(
                name: "IX_PCComponents_SSDM2Id",
                table: "PCComponents",
                column: "SSDM2Id");

            migrationBuilder.CreateIndex(
                name: "IX_PCComponents_VideoCardId",
                table: "PCComponents",
                column: "VideoCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_Motherboards_MotherboardId",
                table: "PCComponents",
                column: "MotherboardId",
                principalTable: "Motherboards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_PCCases_PCCaseId",
                table: "PCComponents",
                column: "PCCaseId",
                principalTable: "PCCases",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_PowerSupplys_PowerSupplyId",
                table: "PCComponents",
                column: "PowerSupplyId",
                principalTable: "PowerSupplys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_Processors_ProcessorId",
                table: "PCComponents",
                column: "ProcessorId",
                principalTable: "Processors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_RAMs_RAMId",
                table: "PCComponents",
                column: "RAMId",
                principalTable: "RAMs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_SSDM2s_SSDM2Id",
                table: "PCComponents",
                column: "SSDM2Id",
                principalTable: "SSDM2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_VideoCards_VideoCardId",
                table: "PCComponents",
                column: "VideoCardId",
                principalTable: "VideoCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
