using DB_Conection_Models.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Conection_Models.Models;

public class Motherboard : IModelDB
{
    public int Id { get ; set ; }
    public string Name { get ; set ; }
}
