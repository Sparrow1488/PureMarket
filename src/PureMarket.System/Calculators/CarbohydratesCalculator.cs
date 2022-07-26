using PureMarket.System.Calculators.Abstractions;
using PureMarket.System.Enums;
using PureMarket.System.Helpers;
using PureMarket.System.Primitives;

namespace PureMarket.System.Calculators;

public class CarbohydratesCalculator : ICarbohydratesCalculator
{
    public DailyCarbohydrates CalculateDailyCarbohydrates(
        BMR bmr, NutrientsTarget target = NutrientsTarget.Default)
    {
        Check.NotNull(bmr, nameof(bmr));

        return new()
        {
            Target = target,
            Value = bmr.LifestyleCaloriesNeeded * 0.3 / 4
        };
    }
}
