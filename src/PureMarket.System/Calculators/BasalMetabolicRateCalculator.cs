using PureMarket.System.Calculators.Abstractions;
using PureMarket.System.Enums;
using PureMarket.System.Exceptions;
using PureMarket.System.Helpers;
using PureMarket.System.Primitives;

namespace PureMarket.System.Calculators;

/// <summary>
///     Harris–Benedict (1984 year) formula calculator
/// </summary>
public class BasalMetabolicRateCalculator : IBasalMetabolicRateCalculator
{
    static BasalMetabolicRateCalculator()
    {
        LifestyleActivityCoefficients = new()
        {
            { LifestyleKind.Sedentary, 1.2 },
            { LifestyleKind.Exercise, 1.375 },
            { LifestyleKind.Sports, 1.55 },
            { LifestyleKind.HardSports, 1.725 },
            { LifestyleKind.ExtraActive, 1.9 }
        };
    }

    public static Dictionary<LifestyleKind, double> LifestyleActivityCoefficients { get; }

    /// <summary>
    ///     Calculated basal metabolic rate (in calories) using clever man formula. See
    ///     https://en.wikipedia.org/wiki/Harris%E2%80%93Benedict_equation
    /// </summary>
    /// <param name="mass">Mass. Not null</param>
    /// <param name="height">Height. Greater or equal 1</param>
    /// <param name="age">Age. Greater or equal 1</param>
    /// <returns>Basal Metabolic Rate, <see cref="BMR"/></returns>
    /// <exception cref="InvalidValueException">Invalid input params</exception>
    /// <exception cref="NullException">Null input param</exception>
    public BMR Calculate(Sex consumer, Mass mass, int height, int age, LifestyleKind lifestyle = LifestyleKind.Sedentary)
    {
        Check.NotNull(mass, nameof(mass));
        Check.This(height).GreaterOrEqual(1, nameof(height));
        Check.This(age).GreaterOrEqual(1, nameof(age));

        switch (consumer)
        {
            case Sex.Man: 
                return CalculateMenBMR(mass, height, age, lifestyle);
            case Sex.Woman:
                return CalculateWomenBMR(mass, height, age, lifestyle);
        };

        throw new NotImplementedException($"For {consumer} consumer type no have any implementation");
    }

    private static BMR CalculateMenBMR(Mass mass, int height, int age, LifestyleKind lifestyle)
    {
        var bmrValue = 88.362 + (13.397 * mass.Value) + (4.799 * height) - (5.677 * age);
        var lifestyleBmr = CalculateLifestyleBMR(bmrValue, lifestyle);
        return new BMR(bmrValue, lifestyleBmr, Sex.Man, lifestyle);
    }

    private static BMR CalculateWomenBMR(Mass mass, int height, int age, LifestyleKind lifestyle)
    {
        var bmrValue = 447.593 + (9.247 * mass.Value) + (3.098 * height) - (4.330 * age);
        var lifestyleBmr = CalculateLifestyleBMR(bmrValue, lifestyle);
        return new BMR(bmrValue, lifestyleBmr, Sex.Woman, lifestyle);
    }

    private static double CalculateLifestyleBMR(double bmr, LifestyleKind lifestyle)
    {
        var coefficient = LifestyleActivityCoefficients[lifestyle];
        return bmr * coefficient;
    }
}
