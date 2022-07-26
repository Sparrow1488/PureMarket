using PureMarket.System.Enums;

namespace PureMarket.System.Primitives;

public class Consumer
{
    public int Age { get; set; }
    public int Height { get; set; }
    public Mass? Mass { get; set; }
    public Sex Sex { get; set; } = Sex.Man;
    public LifestyleKind Lifestyle { get; set; } = LifestyleKind.Sedentary;
}
