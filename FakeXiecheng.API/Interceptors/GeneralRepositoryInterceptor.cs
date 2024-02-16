using AspectCore.DependencyInjection;
using AspectCore.DynamicProxy;
using FakeXiecheng.API.Exceptions;
using FakeXiecheng.API.Helpers;

namespace FakeXiecheng.API.Interceptors
{
    /// <summary>
    /// 基础数据持久层拦截器。添加日志输出和异常处理
    /// </summary>
    public class GeneralRepositoryInterceptor : AbstractInterceptorAttribute
    {
        [FromServiceContext]
        public ILogger<GeneralRepositoryInterceptor>? Logger { get; set; }

        public override async Task Invoke(AspectContext context, AspectDelegate next)
        {
            // 记录方法名
            var methodName = LogHelper.FormatMethodName(context.ServiceMethod);
            // 参数详细描述
            var paramsDescription = LogHelper.FormatMethodParameters(context.ServiceMethod, context.Parameters);

            try
            {
                Logger?.LogDebug("数据访问层调用：{InvokingMethod}，参数信息：{ParamsDescription}", methodName, paramsDescription);

                await next(context);
            }
            catch (Exception ex)
            {
                Logger?.LogError(ex, "数据库操作失败，数据访问层发生异常：{Method}", methodName);

                throw new RepositoryException("数据库操作失败，数据持久化层出现未知错误。", ex);
            }
        }
    }
}
