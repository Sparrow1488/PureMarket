using PureMarket.System.Enums;

namespace PureMarket.System.Primitives;

public class Consumer
{
    public ConsumerType Type { get; } = ConsumerType.Man;
    public double Mass { get; set; }
}
