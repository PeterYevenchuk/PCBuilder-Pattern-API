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

    public async Task<bool> CreateNewPCs(string name, PCComponentDBO pcComponent)
    {
        PCBuilder PCBuilder = new();

        try
        {
            var pc = PCBuilder.SetName(name)
                .SetPCComponent(new PCComponent
                {
                    IdProcessor = pcComponent.IdProcessor,
                    IdVideoCard = pcComponent.IdVideoCard,
                    IdMotherboard = pcComponent.IdMotherboard,
                    IdSSDM2 = pcComponent.IdSSDM2,
                    IdRAM = pcComponent.IdRAM,
                    IdPowerSupply = pcComponent.IdPowerSupply,
                    IdPCCase = pcComponent.IdPCCase
                }).Build();

            _context.PCs.Add(pc);
            _context.SaveChanges();

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
}
