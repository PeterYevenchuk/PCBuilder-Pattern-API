using BLL_Services.Interfaces;
using DB_Conection_Models.Context;
using DB_Conection_Models.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL_Services.Services;

public class PCService
{
    private readonly PCDbContext _context;

    public PCService(PCDbContext context)
    {
        _context = context;
    }

    public List<PC> Get()
    {
        return _context.PCs
        .Include(o => o.PCComponent)
            .ThenInclude(pcComponent => pcComponent.Processor)
        .Include(o => o.PCComponent)
            .ThenInclude(pcComponent => pcComponent.VideoCard)
        .Include(o => o.PCComponent)
            .ThenInclude(pcComponent => pcComponent.Motherboard)
        .Include(o => o.PCComponent)
            .ThenInclude(pcComponent => pcComponent.SSDM2)
        .Include(o => o.PCComponent)
            .ThenInclude(pcComponent => pcComponent.RAM)
        .Include(o => o.PCComponent)
            .ThenInclude(pcComponent => pcComponent.PowerSupply)
        .Include(o => o.PCComponent)
            .ThenInclude(pcComponent => pcComponent.PCCase)
        .ToList();
    }

    public PC GetById(int id)
    {
        return _context.PCs.Include(o => o.PCComponent)
            .ThenInclude(pcComponent => pcComponent.Processor)
        .Include(o => o.PCComponent)
            .ThenInclude(pcComponent => pcComponent.VideoCard)
        .Include(o => o.PCComponent)
            .ThenInclude(pcComponent => pcComponent.Motherboard)
        .Include(o => o.PCComponent)
            .ThenInclude(pcComponent => pcComponent.SSDM2)
        .Include(o => o.PCComponent)
            .ThenInclude(pcComponent => pcComponent.RAM)
        .Include(o => o.PCComponent)
            .ThenInclude(pcComponent => pcComponent.PowerSupply)
        .Include(o => o.PCComponent)
            .ThenInclude(pcComponent => pcComponent.PCCase)
        .FirstOrDefault(o => o.Id == id);
    }

    public bool Update(PC entity)
    {
        try
        {
            var pc = _context.PCs.Include(p => p.PCComponent).FirstOrDefault(o => o.Id == entity.Id);

            if (pc != null)
            {
                pc.Name = entity.Name;

                if (entity.PCComponent != null)
                {
                    pc.PCComponent.IdProcessor = entity.PCComponent.IdProcessor;
                    pc.PCComponent.IdVideoCard = entity.PCComponent.IdVideoCard;
                    pc.PCComponent.IdMotherboard = entity.PCComponent.IdMotherboard;
                    pc.PCComponent.IdSSDM2 = entity.PCComponent.IdSSDM2;
                    pc.PCComponent.IdRAM = entity.PCComponent.IdRAM;
                    pc.PCComponent.IdPowerSupply = entity.PCComponent.IdPowerSupply;
                    pc.PCComponent.IdPCCase = entity.PCComponent.IdPCCase;
                }
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

    public bool Delete(int id)
    {
        var pc = _context.PCs.FirstOrDefault(o => o.Id == id);

        try
        {
            if (pc != null)
            {
                _context.PCs.Remove(pc);
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
