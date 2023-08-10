using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_Conection_Models.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDBInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PCComponents",
                columns: new[] { "Id", "IdMotherboard", "IdPCCase", "IdPowerSupply", "IdProcessor", "IdRAM", "IdSSDM2", "IdVideoCard" },
                values: new object[] { 1, 2, 3, 1, 1, 2, 3, 1 });

            migrationBuilder.InsertData(
                table: "PCs",
                columns: new[] { "Id", "IdPCComponent", "Name" },
                values: new object[] { 1, 1, "Cool Gamer" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PCs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PCComponents",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
