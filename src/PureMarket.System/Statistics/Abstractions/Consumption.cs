using PureMarket.System.Statistics.Structures;

namespace PureMarket.System.Statistics.Abstractions;

public abstract class Consumption
{
    public virtual RangeStatistic DailyCalorieContent { get; internal set; }
}