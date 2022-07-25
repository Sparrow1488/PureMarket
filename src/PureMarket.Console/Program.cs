using PureMarket.System.Enums;
using PureMarket.System.Factories;

Console.WriteLine("PureMarket Welcome!");

var consumptionStatisticsFactory = new DefaultConsumptionProviderFactory();
var statisticsProvider = consumptionStatisticsFactory.Create();

var menConsumption = statisticsProvider.GetConsumption(ConsumerType.Man);
Console.WriteLine("Daily men need to eat {0}-{1} kcal", 
    menConsumption.DailyCalorieContent.StartWith, menConsumption.DailyCalorieContent.EndWith);