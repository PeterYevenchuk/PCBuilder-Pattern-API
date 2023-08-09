using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DB_Conection_Models.Migrations
{
    /// <inheritdoc />
    public partial class NewMigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PCComponents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Processor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoCard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Motherboard = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SSDM2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAM = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PowerSupply = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PCCase = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCComponents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PCs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdComponent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PCs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PCs_PCComponents_IdComponent",
                        column: x => x.IdComponent,
                        principalTable: "PCComponents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PCComponents",
                columns: new[] { "Id", "Motherboard", "PCCase", "PowerSupply", "Processor", "RAM", "SSDM2", "VideoCard" },
                values: new object[] { 1, "AsRock B550", "DeapCool", "Asus 600W", "Amd Ryzen 5 3600", "HyperX 2x16gb", "Sumsung 980gb", "NVidia 3080" });

            migrationBuilder.InsertData(
                table: "PCs",
                columns: new[] { "Id", "IdComponent", "Name" },
                values: new object[] { 1, 1, "Cool Gamer" });

            migrationBuilder.CreateIndex(
                name: "IX_PCs_IdComponent",
                table: "PCs",
                column: "IdComponent");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PCs");

            migrationBuilder.DropTable(
                name: "PCComponents");
        }
    }
}
