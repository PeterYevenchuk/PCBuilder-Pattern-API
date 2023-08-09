
namespace DB_Conection_Models.Models;

public class PC
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int IdComponent { get; set; }
    public PCComponent PCComponent { get; set; }
}
