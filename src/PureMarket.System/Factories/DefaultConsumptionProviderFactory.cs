using PureMarket.System.Factories.Abstractions;
using PureMarket.System.Providers;

namespace PureMarket.System.Factories;

public class DefaultConsumptionProviderFactory : IConsumptionProviderFactory<DefaultConsumptionProvider>
{
    public DefaultConsumptionProvider Create()
    {
        return new();
    }
}
