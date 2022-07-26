using PureMarket.System.Enums;

namespace PureMarket.System.Primitives;

public class Mass
{
    private Mass() { }

    public MassUnits Units { get; private set; }
    public double Value { get; private set; }

    public static Mass CreateIn(MassUnits units, double value)
    {
        return new Mass()
        {
            Units = units,
            Value = value
        };
    }

    public override string ToString()
    {
        return Value + " " + Units.ToString();
    }
}
