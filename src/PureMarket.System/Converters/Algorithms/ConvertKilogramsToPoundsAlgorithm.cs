using PureMarket.System.Constants;
using PureMarket.System.Converters.Abstractions;
using PureMarket.System.Enums;
using PureMarket.System.Primitives;

namespace PureMarket.System.Converters.Algorithms;

public class ConvertKilogramsToPoundsAlgorithm : IMassConvertAlgorithm
{
    public bool CanConvert(MassUnits currentUnits, MassUnits convertUnits)
    {
        return currentUnits is MassUnits.Kilograms && convertUnits is MassUnits.Pounds;
    }

    public Mass Convert(Mass currentKilograms, MassUnits convertUnits)
    {
        return Mass.CreateIn(MassUnits.Pounds, currentKilograms.Value / MassConstants.KilogramsPerOnePound);
    }
}
