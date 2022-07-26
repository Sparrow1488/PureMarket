using PureMarket.System.Converters.Abstractions;
using PureMarket.System.Enums;
using PureMarket.System.Exceptions;

namespace PureMarket.System.Converters;

public class AssemblyConvertAlgorithmSelector : IMassConvertAlgorithmSelector
{
    private static readonly List<IMassConvertAlgorithm> _loadedAlgorithms = new();

    public IMassConvertAlgorithm? Select(MassUnits currentUnits, MassUnits convertUnits)
    {
        LoadAlgorithms();
        var firstAlgorithm = _loadedAlgorithms.FirstOrDefault(
            x => x.CanConvert(currentUnits, convertUnits));
        return firstAlgorithm;
    }

    public IMassConvertAlgorithm SelectRequired(MassUnits currentUnits, MassUnits convertUnits)
    {
        return Select(currentUnits, convertUnits) ?? 
            throw new ConvertAlgorithmNotFoundException($"Not found any algorithm to convert {currentUnits} to {convertUnits}");
    }

    private static void LoadAlgorithms()
    {
        if (_loadedAlgorithms.Count is 0)
        {
            var algorithmTypes = typeof(AssemblyConvertAlgorithmSelector).Assembly
                    .GetTypes().Where(x => x.IsAssignableTo(typeof(IMassConvertAlgorithm)) &&
                                           !x.IsAbstract && !x.IsInterface).ToList();
            algorithmTypes.ForEach(x => _loadedAlgorithms.Add((IMassConvertAlgorithm)Activator.CreateInstance(x)!));
        }
    }
}
