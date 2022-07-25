using PureMarket.System.Constants;
using PureMarket.System.Enums;
using PureMarket.System.Providers.Abstractions;
using PureMarket.System.Statistics;
using PureMarket.System.Statistics.Abstractions;

namespace PureMarket.System.Providers;

public sealed class DefaultConsumptionProvider : IConsumptionStatisticsProvider
{
    public Consumption GetConsumption(ConsumerType consumer)
    {
        switch (consumer)
        {
            case ConsumerType.Man: return GetConsumptionForMan();
            case ConsumerType.Woman: return GetConsumptionForWoman();
        };

        throw new NotImplementedException("Not implemented statistics for " + consumer);
    }

    private static Consumption GetConsumptionForMan()
    {
        return new ConsumptionImp()
        {
            DailyCalorieContent = DailyContentsTable.DailyMenCalorieContent
        };
    }

    private static Consumption GetConsumptionForWoman()
    {
        return new ConsumptionImp()
        {
            DailyCalorieContent = DailyContentsTable.DailyWomenCalorieContent
        };
    }
}
