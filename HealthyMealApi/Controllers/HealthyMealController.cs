using HealthyMeal.api.Mapper;
using HealthyMeal.api.Services;
using HealthyMeal.contracts;
using Microsoft.AspNetCore.Mvc;

namespace HealthyMeal.api.Controllers
{
    [ApiController]
    [Route("api")]
    public class HealthyMealController : ControllerBase
    {
        private readonly IHealthyMealService _healthyMealService;

        public HealthyMealController(IHealthyMealService healthyMealService)
        {
            _healthyMealService = healthyMealService;
        }
        [HttpGet("HealthyMeal/{id:guid}")]
        public ActionResult<ApiResponse> GetHealthyMeal([FromRoute] Guid id) {
            var model = _healthyMealService.GetHealthyMeal(id);
            var response = model.ToHealthyMealResponse();

            return Ok(response);
        }

        [HttpPost("CreateHealthyMeal")]
        public IActionResult CreateHealthyMeal([FromBody] CreateHealthyMealRequest request)
        {
            var model = request.ToHealthyMeal();
            _healthyMealService.CreateHealthyMeal(model);

            var response = model.ToHealthyMealResponse();
            
            return CreatedAtAction(
                    actionName: nameof(GetHealthyMeal),
                    routeValues: new { id = response.Id },
                    value: response
                );
        }

        [HttpPut("UpsertHealthyMeal/{id:guid}")]
        public IActionResult UpsertHealthyMeal([FromRoute] Guid id, [FromBody] UpsertHealthyMealRequest request)
        {
            if (!_healthyMealService.MealExists(id)) 
            {
                var modelx = request.ToHealthyMeal();
                _healthyMealService.CreateHealthyMeal(modelx);

                var response = modelx.ToHealthyMealResponse();

                return CreatedAtAction(
                        actionName: nameof(GetHealthyMeal),
                        routeValues: new { id = response.Id },
                        value: response
                    );
            }
            var model = _healthyMealService.UpsertHealthyMeal(id, request.ToHealthyMeal());
            return Ok(new { id, request });
        }

        [HttpDelete("DeleteHealthyMeal/{id:guid}")]
        public IActionResult DeleteHealthyMeal([FromRoute] Guid id)
        {
            var result = _healthyMealService.DeleteHealthyMeal(id);
            return Ok(result);
        }
    }
}
