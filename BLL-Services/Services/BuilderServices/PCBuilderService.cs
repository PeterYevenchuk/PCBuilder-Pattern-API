using DB_Conection_Models.Context;
using DB_Conection_Models.Models;
using DB_Conection_Models.Models.ModelsDBO;

namespace BLL_Services.Services.BuilderServices;

public class PCBuilderService
{
    private readonly PCDbContext _context;

    public PCBuilderService(PCDbContext context)
    {
        _context = context;
    }

    public async Task<bool> CreateNewPCs(Dictionary<string, PCComponentDBO> pcs)
    {
        PCBuilder PCBuilder = new();

        try
        {
            foreach (var item in pcs)
            {
                var pc = PCBuilder.SetName(item.Key)
                .SetPCComponent(new PCComponent
                {
                    IdProcessor = item.Value.IdProcessor,
                    IdVideoCard = item.Value.IdVideoCard,
                    IdMotherboard = item.Value.IdMotherboard,
                    IdSSDM2 = item.Value.IdSSDM2,
                    IdRAM = item.Value.IdRAM,
                    IdPowerSupply = item.Value.IdPowerSupply,
                    IdPCCase = item.Value.IdPCCase
                }).Build();

                _context.PCs.Add(pc);
                _context.SaveChanges();
            }
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
