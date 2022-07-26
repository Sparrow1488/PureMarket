using PureMarket.System.Enums;

namespace PureMarket.System.Primitives.Abstractions;

public interface IDailyNutrient
{
    NutrientsTarget Target { get; set; }
    double Value { get; set; }
}
