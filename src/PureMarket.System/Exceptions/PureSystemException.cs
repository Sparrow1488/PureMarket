namespace PureMarket.System.Exceptions;

public class PureSystemException : Exception
{
    public PureSystemException()
    {
    }

    public PureSystemException(string? message) : base(message)
    {
    }
}
