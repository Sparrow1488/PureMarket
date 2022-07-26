namespace PureMarket.System.Primitives;

public class DailyNutrients
{
    public BMR? BasalMetabolicRating { get; set; }
    public DailyProtein? DailyProtein { get; set; }
    public DailyCarbohydrates? DailyCarbohydrates { get; set; }
    public DailyFat? DailyFat { get; set; }
}