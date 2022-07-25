using PureMarket.System.Enums;

namespace PureMarket.System.Primitives;

public class Consumer
{
    public Consumer(ConsumerType type, Mass mass)
    {
        Type = type;
        Mass = mass;
    }

    public int Age { get; set; }
    public int Height { get; set; }
    public Mass Mass { get; }
    public ConsumerType Type { get; } = ConsumerType.Man;
}
