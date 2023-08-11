using DB_Conection_Models.Models;
using Microsoft.EntityFrameworkCore;

namespace DB_Conection_Models.Context;

public class PCDbContext : DbContext
{
    public PCDbContext(DbContextOptions<PCDbContext> options) : base(options) {}

    public DbSet<PC> PCs { get; set; }
    public DbSet<PCComponent> PCComponents { get; set; }
    public DbSet<Motherboard> Motherboards { get; set; }
    public DbSet<PCCase> PCCases { get; set; }
    public DbSet<PowerSupply> PowerSupplys { get; set; }
    public DbSet<Processor> Processors { get; set; }
    public DbSet<RAM> RAMs { get; set; }
    public DbSet<SSDM2> SSDM2s { get; set; }
    public DbSet<VideoCard> VideoCards { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PCComponent>()
            .HasOne(c => c.Processor)
            .WithMany()
            .HasForeignKey(c => c.IdProcessor)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<PCComponent>()
            .HasOne(c => c.VideoCard)
            .WithMany()
            .HasForeignKey(c => c.IdVideoCard)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<PCComponent>()
            .HasOne(c => c.Motherboard)
            .WithMany()
            .HasForeignKey(c => c.IdMotherboard)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<PCComponent>()
            .HasOne(c => c.SSDM2)
            .WithMany()
            .HasForeignKey(c => c.IdSSDM2)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<PCComponent>()
            .HasOne(c => c.RAM)
            .WithMany()
            .HasForeignKey(c => c.IdRAM)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<PCComponent>()
            .HasOne(c => c.PowerSupply)
            .WithMany()
            .HasForeignKey(c => c.IdPowerSupply)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<PCComponent>()
            .HasOne(c => c.PCCase)
            .WithMany()
            .HasForeignKey(c => c.IdPCCase)
            .OnDelete(DeleteBehavior.SetNull);

        modelBuilder.Entity<PC>()
            .HasOne(p => p.PCComponent)
            .WithOne()
            .HasForeignKey<PC>(p => p.IdPCComponent);

        modelBuilder.Entity<PC>()
            .HasOne(p => p.PCComponent)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        #region AddInfoPCComponent
        modelBuilder.Entity<PCComponent>().HasData(
                new PCComponent
                {
                    Id = 1,
                    IdMotherboard = 2,
                    IdPCCase = 3,
                    IdPowerSupply = 1,
                    IdProcessor = 1,
                    IdRAM = 2,
                    IdSSDM2 = 3,
                    IdVideoCard = 1,
                });
        #endregion
        #region AddInfoPC
        modelBuilder.Entity<PC>().HasData(
            new PC
            {
                Id = 1,
                Name = "Cool Gamer",
                IdPCComponent = 1
            });
        #endregion
        #region AddInfoMotherboard
        modelBuilder.Entity<Motherboard>().HasData(
            new Motherboard
            {
                Id = 1,
                Name = "AsRock B450"
            },
            new Motherboard
            {
                Id = 2,
                Name = "Gigabyte B550"
            },
            new Motherboard
            {
                Id = 3,
                Name = "MSI X570"
            },
            new Motherboard
            {
                Id = 4,
                Name = "ASUS ROG Strix Z590"
            },
            new Motherboard
            {
                Id = 5,
                Name = "ASRock X470"
            },
            new Motherboard
            {
                Id = 6,
                Name = "Gigabyte B460"
            },
            new Motherboard
            {
                Id = 7,
                Name = "MSI B360"
            },
            new Motherboard
            {
                Id = 8,
                Name = "ASUS Prime A520"
            },
            new Motherboard
            {
                Id = 9,
                Name = "Gigabyte H470"
            },
            new Motherboard
            {
                Id = 10,
                Name = "MSI B450"
            });
        #endregion
        #region AddInfoPCCase
        modelBuilder.Entity<PCCase>().HasData(
            new PCCase
            {
                Id = 1,
                Name = "NZXT H510"
            },
            new PCCase
            {
                Id = 2,
                Name = "Fractal Design Meshify C"
            },
            new PCCase
            {
                Id = 3,
                Name = "Cooler Master MasterBox MB311L"
            },
            new PCCase
            {
                Id = 4,
                Name = "Corsair 4000D"
            },
            new PCCase
            {
                Id = 5,
                Name = "Phanteks Eclipse P400A"
            },
            new PCCase
            {
                Id = 6,
                Name = "Lian Li PC-O11 Dynamic"
            },
            new PCCase
            {
                Id = 7,
                Name = "Thermaltake Versa H18"
            },
            new PCCase
            {
                Id = 8,
                Name = "InWin 303"
            },
            new PCCase
            {
                Id = 9,
                Name = "Be Quiet! Pure Base 500DX"
            },
            new PCCase
            {
                Id = 10,
                Name = "NZXT H710i"
            });
        #endregion
        #region AddInfoPowerSupply
        modelBuilder.Entity<PowerSupply>().HasData(
            new PowerSupply
            {
                Id = 1,
                Name = "Corsair RM750x"
            },
            new PowerSupply
            {
                Id = 2,
                Name = "EVGA Supernova 850 GA"
            },
            new PowerSupply
            {
                Id = 3,
                Name = "Seasonic Focus GX-650"
            },
            new PowerSupply
            {
                Id = 4,
                Name = "Thermaltake Toughpower GF1 750W"
            },
            new PowerSupply
            {
                Id = 5,
                Name = "Be Quiet! Straight Power 11 750W"
            },
            new PowerSupply
            {
                Id = 6,
                Name = "NZXT C850"
            },
            new PowerSupply
            {
                Id = 7,
                Name = "Cooler Master MWE Gold 750 V2"
            },
            new PowerSupply
            {
                Id = 8,
                Name = "Fractal Design Ion+ 760P"
            },
            new PowerSupply
            {
                Id = 9,
                Name = "SilverStone SX800-LTI"
            },
            new PowerSupply
            {
                Id = 10,
                Name = "Seasonic Prime TX-1000"
            });
        #endregion
        #region AddInfoProcessor
        modelBuilder.Entity<Processor>().HasData(
            new Processor
            {
                Id = 1,
                Name = "AMD Ryzen 5 5600X"
            },
            new Processor
            {
                Id = 2,
                Name = "Intel Core i7-11700K"
            },
            new Processor
            {
                Id = 3,
                Name = "AMD Ryzen 7 5800X"
            },
            new Processor
            {
                Id = 4,
                Name = "Intel Core i9-12900K"
            },
            new Processor
            {
                Id = 5,
                Name = "AMD Ryzen 9 5900X"
            },
            new Processor
            {
                Id = 6,
                Name = "Intel Core i5-11600K"
            },
            new Processor
            {
                Id = 7,
                Name = "AMD Ryzen 5 5800"
            },
            new Processor
            {
                Id = 8,
                Name = "Intel Core i5-11400"
            },
            new Processor
            {
                Id = 9,
                Name = "AMD Ryzen 7 5700G"
            },
            new Processor
            {
                Id = 10,
                Name = "Intel Core i7-12700K"
            });
        #endregion
        #region AddInfoRAM
        modelBuilder.Entity<RAM>().HasData(
            new RAM
            {
                Id = 1,
                Name = "Corsair Vengeance LPX 16GB"
            },
            new RAM
            {
                Id = 2,
                Name = "G.Skill Ripjaws V 32GB"
            },
            new RAM
            {
                Id = 3,
                Name = "Crucial Ballistix 8GB"
            },
            new RAM
            {
                Id = 4,
                Name = "Kingston HyperX Fury 16GB"
            },
            new RAM
            {
                Id = 5,
                Name = "Team T-FORCE Vulcan Z 32GB"
            },
            new RAM
            {
                Id = 6,
                Name = "Corsair Dominator Platinum RGB 64GB"
            },
            new RAM
            {
                Id = 7,
                Name = "ADATA XPG Spectrix D60G 16GB"
            },
            new RAM
            {
                Id = 8,
                Name = "Patriot Viper Steel 8GB"
            },
            new RAM
            {
                Id = 9,
                Name = "Crucial Ballistix RGB 32GB"
            },
            new RAM
            {
                Id = 10,
                Name = "HyperX Fury RGB 16GB"
            });
        #endregion
        #region AddInfoSSDM2
        modelBuilder.Entity<SSDM2>().HasData(
            new SSDM2
            {
                Id = 1,
                Name = "Samsung 970 EVO Plus 500GB"
            },
            new SSDM2
            {
                Id = 2,
                Name = "WD Blue SN550 1TB"
            },
            new SSDM2
            {
                Id = 3,
                Name = "Crucial P1 500GB"
            },
            new SSDM2
            {
                Id = 4,
                Name = "Sabrent Rocket Q 2TB"
            },
            new SSDM2
            {
                Id = 5,
                Name = "ADATA XPG SX8200 Pro 1TB"
            },
            new SSDM2
            {
                Id = 6,
                Name = "Kingston A2000 250GB"
            },
            new SSDM2
            {
                Id = 7,
                Name = "Seagate FireCuda 510 1TB"
            },
            new SSDM2
            {
                Id = 8,
                Name = "HP EX950 2TB"
            },
            new SSDM2
            {
                Id = 9,
                Name = "Corsair MP600 2TB"
            },
            new SSDM2
            {
                Id = 10,
                Name = "Gigabyte AORUS NVMe Gen4 1TB"
            });
        #endregion
        #region AddInfoVideoCard
        modelBuilder.Entity<VideoCard>().HasData(
            new VideoCard
            {
                Id = 1,
                Name = "NVIDIA GeForce RTX 3080"
            },
            new VideoCard
            {
                Id = 2,
                Name = "AMD Radeon RX 6800 XT"
            },
            new VideoCard
            {
                Id = 3,
                Name = "NVIDIA GeForce RTX 3070"
            },
            new VideoCard
            {
                Id = 4,
                Name = "AMD Radeon RX 6700 XT"
            },
            new VideoCard
            {
                Id = 5,
                Name = "NVIDIA GeForce RTX 3060 Ti"
            },
            new VideoCard
            {
                Id = 6,
                Name = "AMD Radeon RX 6600 XT"
            },
            new VideoCard
            {
                Id = 7,
                Name = "NVIDIA GeForce GTX 1660 Super"
            },
            new VideoCard
            {
                Id = 8,
                Name = "AMD Radeon RX 5500 XT"
            },
            new VideoCard
            {
                Id = 9,
                Name = "NVIDIA GeForce RTX 3090"
            },
            new VideoCard
            {
                Id = 10,
                Name = "AMD Radeon RX 6900 XT"
            });
        #endregion
    }
}
