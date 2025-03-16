using HealthyMeal.contracts;

namespace HealthyMeal.api.Models
{
    public class ErrorModel
    {
        public int StatusCode { get;  }
        public string ErrorType { get; }
        public string Message { get; }
        public string? Detail { get; }
        public string? Path { get; }
        public DateTime Timestamp { get; } = DateTime.UtcNow;

        public ErrorModel(
            int StatusCode
            , string ErrorType
            , string Message
            , string? Detail
            , string? Path
            )
        {
            this.StatusCode = StatusCode;
            this.ErrorType = ErrorType;
            this.Message = Message;
            this.Detail = Detail;
            this.Path = Path;
            //HERE ADD LOGIC FOR LOGGING IN FILE SYSTEM OR DB.
        }
    }
}
