using HealthyMeal.contracts;
using Microsoft.AspNetCore.Mvc;
using HealthyMeal.api.Models;

namespace HealthyMeal.api.Services
{
    public class HealthyMealService : IHealthyMealService
    {
        private readonly Dictionary<Guid, HealthyMealModel> _healthyMeal = new();
        public void CreateHealthyMeal(HealthyMealModel healthyMealModel)
        {
            _healthyMeal.Add(healthyMealModel.Id, healthyMealModel);
        }

        public HealthyMealModel GetHealthyMeal(Guid id)
        {
            if (!_healthyMeal.ContainsKey(id)) 
            {
                throw new Exception("Item doesn't exists in db.");
            }
            var response = _healthyMeal[id];
            return response;
        }

        public HealthyMealModel UpsertHealthyMeal(Guid id, HealthyMealModel? request)
        {
            if (request is null) 
            { 
                throw new ArgumentNullException(nameof(request));
            }
            _healthyMeal[id] = request;
            return _healthyMeal[id];
        }

        public Guid DeleteHealthyMeal(Guid id)
        {
            _healthyMeal.Remove(id);
            return id;
        }

        public bool MealExists(Guid id)
        {
            return _healthyMeal.ContainsKey(id);
        }
    }
}
