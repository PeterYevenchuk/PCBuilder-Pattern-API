
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DB_Conection_Models.Models;

public class PCComponent
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public int? IdProcessor { get; set; }
    public int? IdVideoCard { get; set; }
    public int? IdMotherboard { get; set; }
    public int? IdSSDM2 { get; set; }
    public int? IdRAM { get; set; }
    public int? IdPowerSupply { get; set; }
    public int? IdPCCase { get; set; }

    public Processor Processor { get; set; }
    public VideoCard VideoCard { get; set; }
    public Motherboard Motherboard { get; set; }
    public SSDM2 SSDM2 { get; set; }
    public RAM RAM { get; set; }
    public PowerSupply PowerSupply { get; set; }
    public PCCase PCCase { get; set; }
}
