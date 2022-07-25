using PureMarket.System.Providers.Abstractions;

namespace PureMarket.System.Factories.Abstractions;

public interface IConsumptionProviderFactory<T>
    where T : IConsumptionStatisticsProvider
{
    T Create();
}
