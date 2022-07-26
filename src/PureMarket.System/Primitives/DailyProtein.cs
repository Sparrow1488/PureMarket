using PureMarket.System.Enums;
using PureMarket.System.Primitives.Abstractions;

namespace PureMarket.System.Primitives;

public class DailyProtein : IDailyNutrient
{
    public NutrientsTarget Target { get; set; } = NutrientsTarget.Default;
    public double Value { get; set; }
}
