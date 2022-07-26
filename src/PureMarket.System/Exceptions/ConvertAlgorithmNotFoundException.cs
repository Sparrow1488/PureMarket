namespace PureMarket.System.Exceptions;

public class ConvertAlgorithmNotFoundException : PureSystemException
{
    public ConvertAlgorithmNotFoundException()
    {
    }

    public ConvertAlgorithmNotFoundException(string? message) : base(message)
    {
    }
}
