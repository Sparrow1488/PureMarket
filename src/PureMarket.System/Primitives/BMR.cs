using PureMarket.System.Enums;

namespace PureMarket.System.Primitives;

public class BMR
{
    public BMR(
        double minimalCaloriesNeeded, 
        double lifestyleCaloriesNeeded, 
        ConsumerType calculatedConsumerType, 
        LifestyleKind lifestyle)
    {
        MinimalCaloriesNeeded = minimalCaloriesNeeded;
        LifestyleCaloriesNeeded = lifestyleCaloriesNeeded;
        CalculatedConsumerType = calculatedConsumerType;
        Lifestyle = lifestyle;
    }

    public double MinimalCaloriesNeeded { get; }
    public double LifestyleCaloriesNeeded { get; }
    public ConsumerType CalculatedConsumerType { get; }
    public LifestyleKind Lifestyle { get; }
}
