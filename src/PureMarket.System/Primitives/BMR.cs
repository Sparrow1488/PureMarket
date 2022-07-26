using PureMarket.System.Enums;

namespace PureMarket.System.Primitives;

public class BMR
{
    public BMR(
        double minimalCaloriesNeeded, 
        double lifestyleCaloriesNeeded, 
        Sex calculatedConsumerType, 
        LifestyleKind lifestyle)
    {
        MinimalCaloriesNeeded = minimalCaloriesNeeded;
        LifestyleCaloriesNeeded = lifestyleCaloriesNeeded;
        CalculatedConsumerType = calculatedConsumerType;
        Lifestyle = lifestyle;
    }

    public double MinimalCaloriesNeeded { get; }
    public double LifestyleCaloriesNeeded { get; }
    public Sex CalculatedConsumerType { get; }
    public LifestyleKind Lifestyle { get; }
}
