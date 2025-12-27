namespace IQAir.Integration.Api.Exceptions;

public class AppInternalException : Exception
{
    public AppInternalException(string? message = null) : base(message)
    {
    }
}