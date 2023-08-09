using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DB_Conection_Models.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatedNewTablesWithInfooo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Motherboards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motherboards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PCCases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCCases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PowerSupplys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PowerSupplys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RAMs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RAMs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SSDM2s",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SSDM2s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VideoCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoCards", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Motherboards",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "AsRock B450" },
                    { 2, "Gigabyte B550" },
                    { 3, "MSI X570" },
                    { 4, "ASUS ROG Strix Z590" },
                    { 5, "ASRock X470" },
                    { 6, "Gigabyte B460" },
                    { 7, "MSI B360" },
                    { 8, "ASUS Prime A520" },
                    { 9, "Gigabyte H470" },
                    { 10, "MSI B450" }
                });

            migrationBuilder.InsertData(
                table: "PCCases",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "NZXT H510" },
                    { 2, "Fractal Design Meshify C" },
                    { 3, "Cooler Master MasterBox MB311L" },
                    { 4, "Corsair 4000D" },
                    { 5, "Phanteks Eclipse P400A" },
                    { 6, "Lian Li PC-O11 Dynamic" },
                    { 7, "Thermaltake Versa H18" },
                    { 8, "InWin 303" },
                    { 9, "Be Quiet! Pure Base 500DX" },
                    { 10, "NZXT H710i" }
                });

            migrationBuilder.InsertData(
                table: "PowerSupplys",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Corsair RM750x" },
                    { 2, "EVGA Supernova 850 GA" },
                    { 3, "Seasonic Focus GX-650" },
                    { 4, "Thermaltake Toughpower GF1 750W" },
                    { 5, "Be Quiet! Straight Power 11 750W" },
                    { 6, "NZXT C850" },
                    { 7, "Cooler Master MWE Gold 750 V2" },
                    { 8, "Fractal Design Ion+ 760P" },
                    { 9, "SilverStone SX800-LTI" },
                    { 10, "Seasonic Prime TX-1000" }
                });

            migrationBuilder.InsertData(
                table: "Processors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "AMD Ryzen 5 5600X" },
                    { 2, "Intel Core i7-11700K" },
                    { 3, "AMD Ryzen 7 5800X" },
                    { 4, "Intel Core i9-12900K" },
                    { 5, "AMD Ryzen 9 5900X" },
                    { 6, "Intel Core i5-11600K" },
                    { 7, "AMD Ryzen 5 5800" },
                    { 8, "Intel Core i5-11400" },
                    { 9, "AMD Ryzen 7 5700G" },
                    { 10, "Intel Core i7-12700K" }
                });

            migrationBuilder.InsertData(
                table: "RAMs",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Corsair Vengeance LPX 16GB" },
                    { 2, "G.Skill Ripjaws V 32GB" },
                    { 3, "Crucial Ballistix 8GB" },
                    { 4, "Kingston HyperX Fury 16GB" },
                    { 5, "Team T-FORCE Vulcan Z 32GB" },
                    { 6, "Corsair Dominator Platinum RGB 64GB" },
                    { 7, "ADATA XPG Spectrix D60G 16GB" },
                    { 8, "Patriot Viper Steel 8GB" },
                    { 9, "Crucial Ballistix RGB 32GB" },
                    { 10, "HyperX Fury RGB 16GB" }
                });

            migrationBuilder.InsertData(
                table: "SSDM2s",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Samsung 970 EVO Plus 500GB" },
                    { 2, "WD Blue SN550 1TB" },
                    { 3, "Crucial P1 500GB" },
                    { 4, "Sabrent Rocket Q 2TB" },
                    { 5, "ADATA XPG SX8200 Pro 1TB" },
                    { 6, "Kingston A2000 250GB" },
                    { 7, "Seagate FireCuda 510 1TB" },
                    { 8, "HP EX950 2TB" },
                    { 9, "Corsair MP600 2TB" },
                    { 10, "Gigabyte AORUS NVMe Gen4 1TB" }
                });

            migrationBuilder.InsertData(
                table: "VideoCards",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "NVIDIA GeForce RTX 3080" },
                    { 2, "AMD Radeon RX 6800 XT" },
                    { 3, "NVIDIA GeForce RTX 3070" },
                    { 4, "AMD Radeon RX 6700 XT" },
                    { 5, "NVIDIA GeForce RTX 3060 Ti" },
                    { 6, "AMD Radeon RX 6600 XT" },
                    { 7, "NVIDIA GeForce GTX 1660 Super" },
                    { 8, "AMD Radeon RX 5500 XT" },
                    { 9, "NVIDIA GeForce RTX 3090" },
                    { 10, "AMD Radeon RX 6900 XT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Motherboards");

            migrationBuilder.DropTable(
                name: "PCCases");

            migrationBuilder.DropTable(
                name: "PowerSupplys");

            migrationBuilder.DropTable(
                name: "Processors");

            migrationBuilder.DropTable(
                name: "RAMs");

            migrationBuilder.DropTable(
                name: "SSDM2s");

            migrationBuilder.DropTable(
                name: "VideoCards");
        }
    }
}
