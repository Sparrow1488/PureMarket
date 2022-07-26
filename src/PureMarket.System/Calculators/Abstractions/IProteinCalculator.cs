using PureMarket.System.Enums;
using PureMarket.System.Primitives;

namespace PureMarket.System.Calculators.Abstractions;

public interface IProteinCalculator
{
    DailyProtein CalculateDailyProtein(BMR bmr, NutrientsTarget target = NutrientsTarget.Default);
}
