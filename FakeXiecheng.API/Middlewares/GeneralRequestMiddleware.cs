using FakeXiecheng.API.Exceptions;

namespace FakeXiecheng.API.Middlewares
{
    /// <summary>
    /// 基础请求中间件。添加日志输出和异常处理功能。
    /// </summary>
    public class GeneralRequestMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public GeneralRequestMiddleware(RequestDelegate next, ILogger<GeneralRequestMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // 请求类型
            var method = context.Request.Method;
            // 请求路径
            var path = context.Request.Path;

            try
            {
                var urlParams = SerializeQueryParams(context.Request.Query); // URL 参数
                var accept = context.Request.Headers["Accept"].ToString(); ; // 请求期望返回类型
                var requestHost = context.Request.Host.Value; // 请求的主机地址
                var remoteIpAddress = context.Connection.RemoteIpAddress?.ToString() ?? "unknown ip"; // 请求的客户端地址
                var reqContentType = context.Request.ContentType; // 请求体类型

                _logger.LogInformation("开始处理请求：{Method} {Path}，URL参数：{UrlParams}，期望返回类型：{Accrpt}，请求媒体类型：{ContentType}，客户端地址：{RemoteIp}，主机地址：{Host}", method, path, urlParams, accept, reqContentType, remoteIpAddress, requestHost);

                // 记录开始时间
                var startTime = DateTime.UtcNow;

                await _next(context);

                // 响应时间
                var elapsed = (DateTime.UtcNow - startTime).TotalMilliseconds; ;

                var statusCode = context.Response.StatusCode; // 响应状态码
                var resContentType = context.Response.ContentType; // 响应体类型

                _logger.LogInformation("请求处理完成：{Method} {Path}， 状态码：{StatusCode}，响应时间：{Elapsed} ms，响应媒体类型：{ContentType}", method, path, statusCode, elapsed, resContentType);
            }
            catch (ServiceException ex)
            {
                _logger.LogError(ex, "请求处理失败：{Method} {Path}，{Message}", method, path, ex.Message);

                throw new ControllerException(400, "请求处理失败，接口出现错误。", ex);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "请求处理失败：{Method} {Path}，系统发生未知异常。", method, path);

                throw new ControllerException(500, "请求处理失败，接口出现未知错误。", ex);
            }
        }

        private static string SerializeQueryParams(IQueryCollection queryParams)
        {
            var serializedParams = queryParams.Select(pair =>
                $"{pair.Key}={(pair.Value.Count > 0 ? string.Join(", ", pair.Value.ToArray()) : "null")}");

            return string.Join(", ", serializedParams);
        }
    }
}
