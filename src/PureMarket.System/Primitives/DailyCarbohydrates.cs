using PureMarket.System.Enums;
using PureMarket.System.Primitives.Abstractions;

namespace PureMarket.System.Primitives;

public class DailyCarbohydrates : IDailyNutrient
{
    public NutrientsTarget Target { get; set; }
    public double Value { get; set; }
}
