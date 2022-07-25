using PureMarket.System.Converters.Abstractions;
using PureMarket.System.Enums;
using PureMarket.System.Primitives;

namespace PureMarket.System.Converters;

public class MassConverter : IMassConverter
{
    public const double KilogramsPerOnePound = 0.45359237;

    public bool TryConvert(Mass current, MassUnits to, out Mass? result)
    {
        if (current.Units is MassUnits.Pounds && to is MassUnits.Kilograms)
        {
            result = PoundsToKilograms(current.Value);
        }
        else if (current.Units is MassUnits.Kilograms && to is MassUnits.Pounds)
        {
            result = KilogramsToPounds(current.Value);
        }
        else if (current.Units == to)
        {
            result = current;
        }
        else
        {
            result = null;
        }

        return (result is not null);
    }

    private static Mass PoundsToKilograms(double pounds) => 
        Mass.CreateIn(MassUnits.Kilograms, pounds * KilogramsPerOnePound);
    private static Mass KilogramsToPounds(double kilograms) =>
        Mass.CreateIn(MassUnits.Pounds, kilograms / KilogramsPerOnePound);
}
