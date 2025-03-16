namespace HealthyMeal.api.Services
{
    public interface IErrorHandlingService
    {
        void HandleErrorHandling(HttpContext httpContext);
    }
}
