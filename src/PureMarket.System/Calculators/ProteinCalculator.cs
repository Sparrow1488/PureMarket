using PureMarket.System.Calculators.Abstractions;
using PureMarket.System.Enums;
using PureMarket.System.Helpers;
using PureMarket.System.Primitives;

namespace PureMarket.System.Calculators;

public class ProteinCalculator : IProteinCalculator
{
    public DailyProtein CalculateDailyProtein(BMR bmr, NutrientsTarget target = NutrientsTarget.Default)
    {
        Check.NotNull(bmr, nameof(bmr));

        return new()
        {
            Target = target,
            Value = bmr.LifestyleCaloriesNeeded * 0.5 / 4
        };
    }
}
