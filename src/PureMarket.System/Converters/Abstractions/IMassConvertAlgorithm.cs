using PureMarket.System.Enums;
using PureMarket.System.Primitives;

namespace PureMarket.System.Converters.Abstractions;

public interface IMassConvertAlgorithm
{
    bool CanConvert(MassUnits currentUnits, MassUnits convertUnits);
    Mass Convert(Mass current, MassUnits convertUnits);
}
