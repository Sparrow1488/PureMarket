using PureMarket.System.Enums;

namespace PureMarket.System.Converters.Abstractions;

public interface IMassConvertAlgorithmSelector
{
    IMassConvertAlgorithm? Select(MassUnits currentUnits, MassUnits convertUnits);
    IMassConvertAlgorithm SelectRequired(MassUnits currentUnits, MassUnits convertUnits);
}
