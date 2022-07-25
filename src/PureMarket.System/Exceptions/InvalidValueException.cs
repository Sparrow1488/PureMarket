namespace PureMarket.System.Exceptions;

internal class InvalidValueException : PureSystemException
{
    public InvalidValueException()
    {
    }

    public InvalidValueException(string? message) : base(message)
    {
    }
}
