using DI_Implementation_Demo.Services;

namespace DI_Implementation_Demo.Implementations;

public class SingletonGuidService : ISingletonGuidService
{
    private Guid guid;
    public SingletonGuidService()
    {
        guid = Guid.NewGuid();
    }
    public string GetGuid()
    {
        return guid.ToString();
    }
}
