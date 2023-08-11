using DB_Conection_Models.Context;
using DB_Conection_Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Services.Services;

public class PCComponentService
{
    private readonly PCDbContext _context;

    public PCComponentService(PCDbContext context)
    {
        _context = context;
    }

    public bool Delete(int id)
    {
        var pcComponent = _context.PCComponents.FirstOrDefault(o => o.Id == id);

        try
        {
            if (pcComponent != null)
            {
                _context.PCComponents.Remove(pcComponent);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
