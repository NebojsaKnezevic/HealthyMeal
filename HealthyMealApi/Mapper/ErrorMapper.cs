using HealthyMeal.api.Models;
using HealthyMeal.contracts;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.Data.SqlClient;
using System;
using static HealthyMeal.api.CustomErrors.CustomErrors;

namespace HealthyMeal.api.Mapper
{
    public static class ErrorMapper
    {
        public static ErrorModel ToErrorModel(this HttpContext httpContext)
        {
            var exception = httpContext.Features.Get<IExceptionHandlerFeature>()?.Error;

            var statusCode = exception switch
            {
                ValidationErrorException validationEx => validationEx.StatusCode,
                ServerErrorException serverEx => serverEx.StatusCode,
                DatabaseErrorException dbEx => dbEx.StatusCode,
                UnauthorizedErrorException unauthorizedEx => unauthorizedEx.StatusCode,
                NotFoundErrorException notFoundEx => notFoundEx.StatusCode,
                ConflictErrorException conflictEx => conflictEx.StatusCode,
                _ => new UnexpectedErrorException("An unexpected error occurred.").StatusCode
            };

            var errorType = exception.GetType().Name.Replace("Exception", "");
            var message = exception.Message;
            var detail = exception?.Message;
            var path = httpContext.Request.Path;

            return new ErrorModel(
                StatusCode: statusCode,
                ErrorType: errorType,
                Message: message,
                Detail: detail,
                Path: path
            );
        }
    }
}
