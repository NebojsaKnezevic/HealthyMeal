namespace HealthyMeal.api.CustomErrors
{
    public class CustomErrors
    {
        public class ValidationErrorException : Exception
        {
            public int StatusCode { get; } = 400; // Bad Request

            public ValidationErrorException(string message) : base(message) { }
        }

        public class ServerErrorException : Exception
        {
            public int StatusCode { get; } = 500; // Internal Server Error

            public ServerErrorException(string message) : base(message) { }
        }

        public class DatabaseErrorException : Exception
        {
            public int StatusCode { get; } = 500; // Internal Server Error

            public DatabaseErrorException(string message) : base(message) { }
        }

        public class UnauthorizedErrorException : Exception
        {
            public int StatusCode { get; } = 401; // Unauthorized

            public UnauthorizedErrorException(string message) : base(message) { }
        }

        public class NotFoundErrorException : Exception
        {
            public int StatusCode { get; } = 404; // Not Found

            public NotFoundErrorException(string message) : base(message) { }
        }

        public class ConflictErrorException : Exception
        {
            public int StatusCode { get; } = 409; // Conflict

            public ConflictErrorException(string message) : base(message) { }
        }

        public class UnexpectedErrorException : Exception
        {
            public int StatusCode { get; } = 500; // Internal Server Error

            public UnexpectedErrorException(string message) : base(message) { }
        }

    }
}
