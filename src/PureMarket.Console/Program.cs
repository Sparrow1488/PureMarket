using PureMarket.System.Calculators;
using PureMarket.System.Enums;
using PureMarket.System.Primitives;

Console.WriteLine("PureMarket Welcome!");

Consumer consumer = new()
{
    Age = 18,
    Height = 170,
    Sex = Sex.Man,
    Lifestyle = LifestyleKind.HardSports,
    Mass = Mass.CreateIn(MassUnits.Kilograms, 56)
};

BasalMetabolicRateCalculator bmrCalculator = new();
ProteinCalculator proteinCalculator = new();
CarbohydratesCalculator carbohydrateCalculator = new();
FatCalculator fatCalculator = new();

var nutrientCalculator = new NutrientCalculator(
    carbohydrateCalculator, bmrCalculator, proteinCalculator, fatCalculator);
var dailyNutrients = nutrientCalculator.CalculateDailyNutrients(consumer);

Console.WriteLine(dailyNutrients);