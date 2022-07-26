using PureMarket.System.Enums;
using PureMarket.System.Primitives;

namespace PureMarket.System.Calculators.Abstractions;

public interface INutrientCalculator
{
    DailyNutrients CalculateDailyNutrients(Consumer consumer, NutrientsTarget nutrientsTarget = NutrientsTarget.Default);
}
