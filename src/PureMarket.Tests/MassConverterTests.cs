using PureMarket.System.Converters;
using PureMarket.System.Enums;
using PureMarket.System.Primitives;

namespace PureMarket.Tests;

public class MassConverterTests
{
    public MassConverter Converter { get; private set; }

    [SetUp]
    public void Setup()
    {
        Converter = new(new AssemblyConvertAlgorithmSelector());
    }

    [Test]
    public void TryConvert_PoundsToKilograms_MassInKilogramUnits()
    {
        Mass expected = Mass.CreateIn(MassUnits.Kilograms, 90.7185);
        Mass pounds = Mass.CreateIn(MassUnits.Pounds, 200);

        var canConvert = Converter.TryConvert(pounds, MassUnits.Kilograms, out var result);

        AssertDefault(expected, result, canConvert);
    }

    [Test]
    public void TryConvert_KilogramsToPounds_MassInPoundsUnits()
    {
        Mass expected = Mass.CreateIn(MassUnits.Pounds, 198.416);
        Mass kilograms = Mass.CreateIn(MassUnits.Kilograms, 90);

        var canConvert = Converter.TryConvert(kilograms, MassUnits.Pounds, out var result);

        AssertDefault(expected, result, canConvert);
    }

    private void AssertDefault(Mass expected, Mass? actual, bool canConvert)
    {
        Assert.That(actual, Is.Not.Null);

        const int afterDotDigits = 4;
        var expectedValue = Math.Round(expected!.Value, afterDotDigits, MidpointRounding.ToEven);
        var resultValue = Math.Round(actual!.Value, afterDotDigits, MidpointRounding.ToEven);

        Assert.Multiple(() => {
            Assert.That(canConvert, Is.True);
            Assert.That(resultValue, Is.EqualTo(expectedValue));
            Assert.That(actual.Units, Is.EqualTo(expected.Units));
        });
    }
}
