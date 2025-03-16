using HealthyMeal.api.Models;
using HealthyMeal.contracts;
using Microsoft.AspNetCore.Mvc;

namespace HealthyMeal.api.Services
{
    public interface IHealthyMealService
    {
        void CreateHealthyMeal(HealthyMealModel request);
        HealthyMealModel GetHealthyMeal(Guid id);
        HealthyMealModel UpsertHealthyMeal(Guid id, HealthyMealModel? request);
        Guid DeleteHealthyMeal(Guid id);
        bool MealExists(Guid id);
    }
}
