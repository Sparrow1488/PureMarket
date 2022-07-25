using PureMarket.System.Enums;
using PureMarket.System.Primitives;

namespace PureMarket.Tests;

public class MassTests
{
    public Mass MassInKilograms { get; set; } = null!;
    public Mass MassInPounds { get; set; } = null!;

    [SetUp]
    public void Setup()
    {
        MassInKilograms = Mass.CreateIn(MassUnits.Kilograms, 55);
        MassInPounds = Mass.CreateIn(MassUnits.Pounds, 122);
    }

    [Test(Author = "Sparrow1488")]
    public void Mass_Kilograms_ToString()
    {
        var excepted = "55 Kilograms";

        var result = MassInKilograms.ToString();
        StringAssert.AreEqualIgnoringCase(result, excepted);
    }

    [Test(Author = "Sparrow1488")]
    public void Mass_Pounds_ToString()
    {
        var excepted = "122 Pounds";

        var result = MassInPounds.ToString();
        StringAssert.AreEqualIgnoringCase(result, excepted);
    }
}