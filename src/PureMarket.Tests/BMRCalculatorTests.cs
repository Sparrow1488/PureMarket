using PureMarket.System.Calculators;
using PureMarket.System.Enums;
using PureMarket.System.Primitives;

namespace PureMarket.Tests;

public class BMRCalculatorTests
{
    public Consumer ManConsumer { get; private set; }
    public Consumer WomanConsumer { get; private set; }

    [SetUp]
    public void Setup()
    {
        ManConsumer = new() {
            Age = 18,
            Height = 170,
            Sex = Sex.Man,
            Mass = Mass.CreateIn(MassUnits.Kilograms, 56)
        };

        WomanConsumer = new() {
            Age = 18,
            Height = 155,
            Sex = Sex.Woman,
            Mass = Mass.CreateIn(MassUnits.Kilograms, 50)
        };
    }

    [Test]
    public void Calculate_ManConsumerInfo_BMR()
    {
        var calculator = new BasalMetabolicRateCalculator();
        var consumer = ManConsumer;

        var bmrResult = calculator.Calculate(
            consumer.Sex, consumer.Mass!, consumer.Height, consumer.Age, consumer.Lifestyle);
        AssertBasalMetabolicRateDefault(bmrResult, consumer);
    }

    [Test]
    public void Calculate_WomanConsumerInfo_BMR()
    {
        var calculator = new BasalMetabolicRateCalculator();
        var consumer = WomanConsumer;

        var bmrResult = calculator.Calculate(
            consumer.Sex, consumer.Mass!, consumer.Height, consumer.Age, consumer.Lifestyle);
        AssertBasalMetabolicRateDefault(bmrResult, consumer);
    }

    private static void AssertBasalMetabolicRateDefault(BMR result, Consumer consumer)
    {
        Assert.Multiple(() =>
        {
            Assert.That(result.Lifestyle, Is.EqualTo(consumer.Lifestyle));
            Assert.That(result.CalculatedConsumerType, Is.EqualTo(consumer.Sex));
            Assert.That(result.MinimalCaloriesNeeded, Is.GreaterThan(0));
            Assert.That(result.LifestyleCaloriesNeeded, Is.GreaterThan(result.MinimalCaloriesNeeded));
        });
    }
}
