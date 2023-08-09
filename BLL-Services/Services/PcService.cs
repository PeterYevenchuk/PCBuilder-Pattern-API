using BLL_Services.Interfaces;
using DB_Conection_Models.Context;
using DB_Conection_Models.Models;

namespace BLL_Services.Services;

public class PcService : IService<PC>
{
    private readonly PCDbContext _context;

    public PcService(PCDbContext context)
    {
        _context = context;
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<PC> Get()
    {
        return _context.PCs.ToList();
    }

    public PC GetById(int id)
    {
        throw new NotImplementedException();
    }

    public bool Insert(PC entity)
    {
        throw new NotImplementedException();
    }

    public bool Update(PC entity)
    {
        throw new NotImplementedException();
    }
}
