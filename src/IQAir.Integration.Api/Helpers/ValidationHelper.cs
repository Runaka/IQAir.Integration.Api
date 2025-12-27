using System.ComponentModel.DataAnnotations;
using System.Text.Json.Nodes;
using IQAir.Integration.Api.Exceptions;
using Newtonsoft.Json;

namespace IQAir.Integration.Api.Helpers;

public static class ValidationHelper
{
    public static void IsNotValidThrowException<T>(T instance)
    {
        var context = new ValidationContext(instance!);
        var results = new List<ValidationResult>();
        var isValid = Validator.TryValidateObject(instance!, context, results, true);
        if (!isValid)
        {
            var errors = results.Select(r => r.ErrorMessage ?? "Unknown error").ToList();
            throw new AppValidationRequestException($"Error validate request {context.DisplayName}, {JsonConvert.SerializeObject(context.ObjectInstance)}, {JsonConvert.SerializeObject(errors)}");
        }
    }   
}