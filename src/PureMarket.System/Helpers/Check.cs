using PureMarket.System.Exceptions;

namespace PureMarket.System.Helpers;

public static class Check
{
    public static ValueContainer<TValue> This<TValue>(TValue value)
    {
        return new ValueContainer<TValue>(value);
    }

    public static void NotNull<TValue>(TValue value, string? objectName = null)
    {
        _ = value ?? throw new NullException($"Input {objectName ?? "object"} value was null");
    }

    public class ValueContainer<TValue>
    {
        public ValueContainer(TValue value)
        {
            Value = value;
        }

        public TValue Value { get; }
    }

    public static void GreaterOrEqual(this ValueContainer<int> container, int greaterOrEqual, string? objectName = null)
    {
        if (container.Value < greaterOrEqual)
        {
            throw new InvalidValueException($"Input {objectName ?? "object"} with value {container.Value} should be greater or equals {greaterOrEqual}");
        }
    }
}
