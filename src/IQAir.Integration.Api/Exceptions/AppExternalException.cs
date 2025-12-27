namespace IQAir.Integration.Api.Exceptions;

public class AppExternalException: Exception
{
    public AppExternalException(string? message = null) : base(message)
    {
    }
}