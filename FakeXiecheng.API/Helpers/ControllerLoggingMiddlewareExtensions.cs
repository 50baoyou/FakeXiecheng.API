using FakeXiecheng.API.Middlewares;

namespace FakeXiecheng.API.Helpers
{
    public static class ControllerLoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseControllerLogging(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<GeneralRequestMiddleware>();
        }
    }
}
