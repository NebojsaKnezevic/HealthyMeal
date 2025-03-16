using HealthyMeal.api.Models;
using HealthyMeal.contracts;
using Microsoft.AspNetCore.Mvc;

namespace HealthyMeal.api.Controllers
{
    [Route("error")]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [HttpGet]
        public IActionResult ErrorHandler(HttpContext httpContext) 
        {
            var response = new ApiResponse();
            response.IsSuccessful = false;
            //response.Data = new ErrorModel();
            return Ok(new ApiResponse());
        }
    }
}
