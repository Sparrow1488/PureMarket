using PureMarket.System.Enums;
using PureMarket.System.Primitives;

namespace PureMarket.System.Calculators.Abstractions;

public interface IFatCalculator
{
    DailyFat CalculateDailyFat(BMR bmr, NutrientsTarget target = NutrientsTarget.Default);
}
