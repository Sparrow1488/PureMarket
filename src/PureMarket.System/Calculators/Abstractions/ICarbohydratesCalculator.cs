using PureMarket.System.Enums;
using PureMarket.System.Primitives;

namespace PureMarket.System.Calculators.Abstractions;

public interface ICarbohydratesCalculator
{
    DailyCarbohydrates CalculateDailyCarbohydrates(
        BMR bmr, NutrientsTarget target = NutrientsTarget.Default);
}
