namespace PureMarket.System.Statistics.Structures;

public struct RangeStatistic
{
    public RangeStatistic(double startWith, double endWith)
    {
        StartWith = startWith;
        EndWith = endWith;
    }

    public double StartWith { get; }
    public double EndWith { get; }
}
