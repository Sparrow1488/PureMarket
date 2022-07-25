namespace PureMarket.System.Exceptions;

internal class NullException : PureSystemException
{
    public NullException()
    {
    }

    public NullException(string? message) : base(message)
    {
    }
}
