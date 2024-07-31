using DI_Implementation_Demo.Services;

namespace DI_Implementation_Demo.Implementations;

public class TransientGuidService : ITransientGuidService
{
    private Guid guid;
    public TransientGuidService()
    {
        guid = Guid.NewGuid();
    }
    public string GetGuid()
    {
        return guid.ToString();
    }
}
