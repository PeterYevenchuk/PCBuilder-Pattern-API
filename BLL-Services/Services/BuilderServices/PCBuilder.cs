using DB_Conection_Models.Models;

namespace BLL_Services.Services.BuilderServices;

public class PCBuilder
{
    private readonly PC _pc;

    public PCBuilder()
    {
        _pc = new PC();
    }

    public PCBuilder SetName(string name)
    {
        _pc.Name = name;
        return this;
    }

    public PCBuilder SetPCComponent(PCComponent pcComponent)
    {
        _pc.PCComponent = pcComponent;
        return this;
    }

    public PC Build()
    {
        return _pc;
    }
}
