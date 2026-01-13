namespace TaskService.Application.Common
{
    public class Result<T>
    {
        public string Message { get; }
        public IEnumerable<T> Data { get; }
        public Status Status { get; }

        private Result(string message, IEnumerable<T> data, Status status)
        {
            Message = message;
            Data = data;
            Status = status;
        }

        public static Result<T> Success(IEnumerable<T> data, string? message = null)
        {
            return new Result<T>(message, data, Status.Success);
        }

        public static Result<T> Failed(string? message)
        {
            return new Result<T>(message, Enumerable.Empty<T>(), Status.Failed);
        }

        public static Result<T> NotFound(string? message)
        {
            return new Result<T>(message, Enumerable.Empty<T>(), Status.NotFound);
        }
    }

    public enum Status
    {
        Success,
        Failed,
        NotFound
    }
}
