namespace IQAir.Integration.Api.Exceptions;

public class AppValidationRequestException : Exception
{
    public AppValidationRequestException(string? message = null) : base(message)
    {
    }
}