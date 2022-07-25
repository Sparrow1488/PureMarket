using PureMarket.System.Calculators.Abstractions;
using PureMarket.System.Enums;
using PureMarket.System.Helpers;
using PureMarket.System.Primitives;

namespace PureMarket.System.Calculators;

/// <summary>
///     Harris–Benedict (1984 year) formula calculator
/// </summary>
public class BasalMetabolicRateCalculator : IBasalMetabolicRateCalculator
{
    public BMR Calculate(ConsumerType consumer, Mass mass, int height, int age)
    {
        Check.NotNull(mass, nameof(mass));
        Check.This(height).GreaterOrEqual(1, nameof(height));
        Check.This(age).GreaterOrEqual(1, nameof(age));

        switch (consumer)
        {
            case ConsumerType.Man: 
                return CalculateMenBMR(mass, height, age);
            case ConsumerType.Woman:
                return CalculateWomenBMR(mass, height, age);
        };

        throw new NotImplementedException($"For {consumer} consumer type no have any implementation");
    }

    private static BMR CalculateMenBMR(Mass mass, int height, int age)
    {
        var bmrValue = 88.362 + (13.397 * mass.Value) + (4.799 * height) - (5.677 * age);
        return new(bmrValue);
    }

    private static BMR CalculateWomenBMR(Mass mass, int height, int age)
    {
        var bmrValue = 447.593 + (9.247 * mass.Value) + (3.098 * height) - (4.330 * age);
        return new(bmrValue);
    }
}
