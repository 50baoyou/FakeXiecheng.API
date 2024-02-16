using AspectCore.DependencyInjection;
using AspectCore.DynamicProxy;
using AutoMapper;
using FakeXiecheng.API.Exceptions;
using FakeXiecheng.API.Helpers;

namespace FakeXiecheng.API.Interceptors
{
    /// <summary>
    /// 基础服务层拦截器。添加日志输出和异常处理功能。
    /// </summary>
    public class GeneralServiceInterceptor : AbstractInterceptorAttribute
    {
        [FromServiceContext]
        public ILogger<GeneralServiceInterceptor>? Logger { get; set; }

        public override async Task Invoke(AspectContext context, AspectDelegate next)
        {
            // 记录方法名
            var methodName = LogHelper.FormatMethodName(context.ServiceMethod);
            // 参数详细描述
            var paramsDescription = LogHelper.FormatMethodParameters(context.ServiceMethod, context.Parameters);

            try
            {
                Logger?.LogInformation("开始处理数据：{Method}", methodName);
                Logger?.LogDebug("服务层调用：{InvokingMethod}，参数信息：{ParamsDescription}", methodName, paramsDescription);

                await next(context);

                Logger?.LogInformation("数据处理完成：{Method}", methodName);
            }
            catch (ArgumentException ex)
            {
                Logger?.LogError(ex, "数据处理失败，在对参数解析时发生异常：{Method}", methodName);

                throw new ServiceException("数据处理失败，对参数进行解析时出现错误。", ex);
            }
            catch (RepositoryException ex)
            {
                Logger?.LogError(ex, "数据处理失败，在获取数据时发生异常：{Method}", methodName);

                throw new ServiceException("数据处理失败，数据持久化层出现错误。", ex);
            }
            catch (AutoMapperMappingException ex)
            {
                Logger?.LogError(ex, "数据处理失败，在进行数据映射时发生异常：{Method}", methodName);

                throw new ServiceException("数据处理失败，对数据进行映射出现错误。", ex);
            }
            catch (Exception ex)
            {
                Logger?.LogError(ex, "数据处理失败，服务层发生异常：{Method}", methodName);

                throw new ServiceException("数据处理失败，服务层出现未知错误。", ex);
            }
        }
    }
}
