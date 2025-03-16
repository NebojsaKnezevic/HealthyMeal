using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyMeal.contracts
{
    public class ErrorResponse
    {
        public int StatusCode { get; set; }
        public string ErrorType { get; set; }
        public string Message { get; set; }
        public string? Detail { get; set; }
        public string? Path { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
