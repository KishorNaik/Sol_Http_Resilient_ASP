namespace Sol_Demo.DTO;

public class DataResponse<T>
{
    public DataResponse(bool? success, int? statusCode, T data, string message)
    {
        this.Success = success;
        this.StatusCode = statusCode;
        this.Data = data;
        this.Message = message;
    }

    public bool? Success { get; }

    public string? Message { get; }

    public T Data { get; }

    public int? StatusCode { get; }
}