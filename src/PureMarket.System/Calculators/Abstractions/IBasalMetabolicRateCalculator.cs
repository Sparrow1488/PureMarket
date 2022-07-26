using PureMarket.System.Enums;
using PureMarket.System.Primitives;

namespace PureMarket.System.Calculators.Abstractions;

public interface IBasalMetabolicRateCalculator
{
    BMR Calculate(Sex consumer, Mass mass, int height, int age, LifestyleKind lifestyle = LifestyleKind.Sedentary);
}
