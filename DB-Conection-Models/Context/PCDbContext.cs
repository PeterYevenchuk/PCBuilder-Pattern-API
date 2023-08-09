using DB_Conection_Models.Models;
using Microsoft.EntityFrameworkCore;

namespace DB_Conection_Models.Context;

public class PCDbContext : DbContext
{
    public PCDbContext(DbContextOptions<PCDbContext> options) : base(options) {}

    public DbSet<PC> PCs { get; set; }
    public DbSet<PCComponent> PCComponents { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Foreign key for PC table
        modelBuilder.Entity<PC>()
            .HasOne(o => o.PCComponent)
            .WithMany()
            .HasForeignKey("IdComponent")
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<PCComponent>().HasData
            (
                new PCComponent
                {
                    Id = 1,
                    Processor = "Amd Ryzen 5 3600",
                    VideoCard = "NVidia 3080",
                    Motherboard = "AsRock B550",
                    SSDM2 = "Sumsung 980gb",
                    RAM = "HyperX 2x16gb",
                    PowerSupply = "Asus 600W",
                    PCCase = "DeapCool"
                }
            );

        modelBuilder.Entity<PC>().HasData(
            new PC
                {
                    Id = 1,
                    Name = "Cool Gamer",
                    IdComponent = 1
                }
            );
    }
}
