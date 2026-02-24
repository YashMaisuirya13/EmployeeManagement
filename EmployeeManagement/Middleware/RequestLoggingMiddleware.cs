namespace EmployeeManagement.Middleware;
public class RequestLoggingMiddleware
{
    private readonly RequestDelegate _next;

    public RequestLoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        var start = DateTime.Now;
        await _next(context);
        var end = DateTime.Now;
        Console.WriteLine($"{context.Request.Method} {context.Request.Path} - Time: {(end - start).TotalMilliseconds}ms");
    }
}
