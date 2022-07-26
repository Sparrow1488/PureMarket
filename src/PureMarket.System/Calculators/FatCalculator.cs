using PureMarket.System.Calculators.Abstractions;
using PureMarket.System.Enums;
using PureMarket.System.Helpers;
using PureMarket.System.Primitives;

namespace PureMarket.System.Calculators;

public class FatCalculator : IFatCalculator
{
    public DailyFat CalculateDailyFat(BMR bmr, NutrientsTarget target = NutrientsTarget.Default)
    {
        Check.NotNull(bmr, nameof(bmr));

        return new()
        {
            Target = target,
            Value = bmr.LifestyleCaloriesNeeded * 0.2 / 9
        };
    }
}
