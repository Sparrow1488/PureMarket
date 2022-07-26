using PureMarket.System.Converters.Abstractions;
using PureMarket.System.Enums;
using PureMarket.System.Helpers;
using PureMarket.System.Primitives;

namespace PureMarket.System.Converters;

public class MassConverter : IMassConverter
{
    public MassConverter(
        IMassConvertAlgorithmSelector algorithmSelector)
    {
        AlgorithmSelector = algorithmSelector;
    }

    public IMassConvertAlgorithmSelector AlgorithmSelector { get; }

    public bool TryConvert(Mass current, MassUnits to, out Mass? result)
    {
        Check.NotNull(current, nameof(current));

        if (current.Units == to)
        {
            result = current;
        }
        else
        {
            result = AlgorithmSelector.SelectRequired(current.Units, to).Convert(current, to);
        }
        return (result is not null);
    }
}
