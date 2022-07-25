using PureMarket.System.Enums;
using PureMarket.System.Statistics.Abstractions;

namespace PureMarket.System.Providers.Abstractions;

public interface IConsumptionStatisticsProvider
{
    Consumption GetConsumption(ConsumerType consumer);
}
