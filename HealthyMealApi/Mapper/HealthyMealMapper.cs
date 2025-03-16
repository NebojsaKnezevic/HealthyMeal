

using HealthyMeal.api.Models;
using HealthyMeal.contracts;

namespace HealthyMeal.api.Mapper
{
    public static class HealthyMealMapper
    {
        public static HealthyMealModel ToHealthyMeal(this CreateHealthyMealRequest request)
        {
            return new HealthyMealModel
            (
                Guid.NewGuid(),
                request.Name,
                request.Description,
                request.StartDateTime,
                request.EndDateTime,
                request.Savory,
                request.Sweet
            );
        }

        public static HealthyMealModel ToHealthyMeal(this UpsertHealthyMealRequest request)
        {
            return new HealthyMealModel
            (
                Guid.NewGuid(),
                request.Name,
                request.Description,
                request.StartDateTime,
                request.EndDateTime,
                request.Savory,
                request.Sweet
            );
        }


        public static HealthyMealResponse ToHealthyMealResponse(this HealthyMealModel request)
        {
            return new HealthyMealResponse
            (
                request.Id,
                request.Name,
                request.Description,
                request.StartDateTime,
                request.EndDateTime,
                 DateTime.UtcNow,
                request.Savory,
                request.Sweet
            );
        }
    }
}
