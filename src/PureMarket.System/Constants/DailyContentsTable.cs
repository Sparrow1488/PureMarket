using PureMarket.System.Statistics.Structures;

namespace PureMarket.System.Constants;

public static class DailyContentsTable
{
    public static readonly RangeStatistic DailyMenCalorieContent = new(2000, 2500);
    public static readonly RangeStatistic DailyWomenCalorieContent = new(1500, 2000);
}
