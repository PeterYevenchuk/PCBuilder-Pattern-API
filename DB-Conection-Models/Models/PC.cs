
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DB_Conection_Models.Models;

public class PC
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Name { get; set; }
    public int IdPCComponent { get; set; }
    public PCComponent PCComponent { get; set; }
}
