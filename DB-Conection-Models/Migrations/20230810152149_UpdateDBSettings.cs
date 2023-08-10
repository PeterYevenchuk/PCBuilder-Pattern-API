using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_Conection_Models.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDBSettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_PCs_IdPCComponent",
                table: "PCs",
                column: "IdPCComponent",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_Motherboards_IdMotherboard",
                table: "PCComponents",
                column: "IdMotherboard",
                principalTable: "Motherboards",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_PCCases_IdPCCase",
                table: "PCComponents",
                column: "IdPCCase",
                principalTable: "PCCases",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_PowerSupplys_IdPowerSupply",
                table: "PCComponents",
                column: "IdPowerSupply",
                principalTable: "PowerSupplys",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_Processors_IdProcessor",
                table: "PCComponents",
                column: "IdProcessor",
                principalTable: "Processors",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_RAMs_IdRAM",
                table: "PCComponents",
                column: "IdRAM",
                principalTable: "RAMs",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_SSDM2s_IdSSDM2",
                table: "PCComponents",
                column: "IdSSDM2",
                principalTable: "SSDM2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_PCComponents_VideoCards_IdVideoCard",
                table: "PCComponents",
                column: "IdVideoCard",
                principalTable: "VideoCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_PCs_PCComponents_IdPCComponent",
                table: "PCs",
                column: "IdPCComponent",
                principalTable: "PCComponents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.DropForeignKey(
                name: "FK_PCs_PCComponents_IdPCComponent",
                table: "PCs");

            migrationBuilder.DropIndex(
                name: "IX_PCs_IdPCComponent",
                table: "PCs");

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
    }
}
