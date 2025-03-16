using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyMeal.contracts
{
    public class ApiResponse
    {
        public bool IsSuccessful { get; set; }
        public object Data { get; set; }
    }
}
