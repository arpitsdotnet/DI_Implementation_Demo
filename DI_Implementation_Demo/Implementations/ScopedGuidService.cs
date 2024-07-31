using DI_Implementation_Demo.Services;

namespace DI_Implementation_Demo.Implementations;

public class ScopedGuidService : IScopedGuidService
{
    private Guid guid;
    public ScopedGuidService()
    {
        guid = Guid.NewGuid();
    }
    public string GetGuid()
    {
        return guid.ToString();
    }
}
