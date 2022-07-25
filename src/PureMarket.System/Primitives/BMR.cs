using PureMarket.System.Enums;

namespace PureMarket.System.Primitives;

public class BMR
{
    public BMR(double minimalCaloriesNeeded)
    {
        MinimalCaloriesNeeded = minimalCaloriesNeeded;
    }

    public double MinimalCaloriesNeeded { get; }
    public ConsumerType CalculatedConsumerType { get; }
}
