using PureMarket.System.Calculators;
using PureMarket.System.Enums;
using PureMarket.System.Factories;
using PureMarket.System.Primitives;

Console.WriteLine("PureMarket Welcome!");

Consumer consumer = new()
{
    Age = 18,
    Height = 170,
    Type = ConsumerType.Man,
    Mass = Mass.CreateIn(MassUnits.Kilograms, 56)
};

BasalMetabolicRateCalculator bmrCalculator = new();
var consumerBmr = bmrCalculator.Calculate(consumer.Type, consumer.Mass, consumer.Height, consumer.Age, LifestyleKind.Sports);
Console.WriteLine("Consumer BMR is {0} calories, with your activity - {1}", 
    consumerBmr.MinimalCaloriesNeeded, consumerBmr.LifestyleCaloriesNeeded);

var consumptionStatisticsFactory = new DefaultConsumptionProviderFactory();
var statisticsProvider = consumptionStatisticsFactory.Create();

var menConsumption = statisticsProvider.GetConsumption(ConsumerType.Man);
Console.WriteLine("Daily men need to eat {0}-{1} kcal", 
    menConsumption.DailyCalorieContent.StartWith, menConsumption.DailyCalorieContent.EndWith);