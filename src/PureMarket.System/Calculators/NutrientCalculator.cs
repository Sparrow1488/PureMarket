using PureMarket.System.Calculators.Abstractions;
using PureMarket.System.Enums;
using PureMarket.System.Primitives;

namespace PureMarket.System.Calculators;

public class NutrientCalculator : INutrientCalculator
{
    public NutrientCalculator(
        ICarbohydratesCalculator carbohydratesCalculator,
        IBasalMetabolicRateCalculator bmrCalculator,
        IProteinCalculator proteinCalculator,
        IFatCalculator fatCalculator)
    {
        BmrCalculator = bmrCalculator;
        FatCalculator = fatCalculator;
        ProteinCalculator = proteinCalculator;
        CarbohydratesCalculator = carbohydratesCalculator;
    }

    public ICarbohydratesCalculator CarbohydratesCalculator { get; }
    public IBasalMetabolicRateCalculator BmrCalculator { get; }
    public IProteinCalculator ProteinCalculator { get; }
    public IFatCalculator FatCalculator { get; }

    public DailyNutrients CalculateDailyNutrients(
        Consumer consumer, NutrientsTarget nutrientsTarget = NutrientsTarget.Default)
    {
        var bmr = BmrCalculator.Calculate(consumer.Sex, consumer.Mass!, consumer.Height, consumer.Age, consumer.Lifestyle);
        var dailyProtein = ProteinCalculator.CalculateDailyProtein(bmr, nutrientsTarget);
        var dailyCarbohydrates = CarbohydratesCalculator.CalculateDailyCarbohydrates(bmr, nutrientsTarget);
        var dailyFat = FatCalculator.CalculateDailyFat(bmr, nutrientsTarget);

        return new()
        {
            BasalMetabolicRating = bmr,
            DailyProtein = dailyProtein,
            DailyCarbohydrates = dailyCarbohydrates,
            DailyFat = dailyFat
        };
    }
}
