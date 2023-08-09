
using DB_Conection_Models.Interfaces;

namespace DB_Conection_Models.Models;

public class Processor : IModelDB
{
    public int Id { get; set; }
    public string Name { get; set; }
}
