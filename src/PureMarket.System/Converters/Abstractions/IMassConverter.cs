using PureMarket.System.Enums;
using PureMarket.System.Primitives;

namespace PureMarket.System.Converters.Abstractions;

public interface IMassConverter
{
    bool TryConvert(Mass from, MassUnits to, out Mass? result);
}
