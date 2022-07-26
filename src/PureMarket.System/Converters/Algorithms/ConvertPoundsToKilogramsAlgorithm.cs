using PureMarket.System.Constants;
using PureMarket.System.Converters.Abstractions;
using PureMarket.System.Enums;
using PureMarket.System.Primitives;

namespace PureMarket.System.Converters.Algorithms;

public class ConvertPoundsToKilogramsAlgorithm : IMassConvertAlgorithm
{
    public bool CanConvert(MassUnits currentUnits, MassUnits convertUnits)
    {
        return currentUnits is MassUnits.Pounds && convertUnits is MassUnits.Kilograms;
    }

    public Mass Convert(Mass currentPounds, MassUnits convertUnits)
    {
        return Mass.CreateIn(MassUnits.Kilograms, currentPounds.Value * MassConstants.KilogramsPerOnePound);
    }
}
