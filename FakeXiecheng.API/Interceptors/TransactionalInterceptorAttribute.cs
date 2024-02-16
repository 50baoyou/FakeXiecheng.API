using AspectCore.DependencyInjection;
using AspectCore.DynamicProxy;
using FakeXiecheng.API.Database;
using FakeXiecheng.API.Exceptions;
using FakeXiecheng.API.Helpers;
using Microsoft.EntityFrameworkCore;

namespace FakeXiecheng.API.Interceptors
{
    public class TransactionalInterceptorAttribute : AbstractInterceptorAttribute
    {
        [FromServiceContext]
        public FakeXieChengContext? DbContext { get; set; }
        [FromServiceContext]
        public ILogger<TransactionalInterceptorAttribute>? Logger { get; set; }

        public override async Task Invoke(AspectContext context, AspectDelegate next)
        {
            if (DbContext == null)
            {
                Logger?.LogError("事务管理失败，DbContext 未注入成功：{Method}", context.ImplementationMethod.Name);
                throw new RepositoryException("事务管理失败，DbContext 未注入成功。");
            }

            // 检查是否已经在一个事务中，如果是，则直接执行
            if (DbContext.Database.CurrentTransaction != null)
            {
                await next(context);
                return;
            }

            var strategy = DbContext.Database.CreateExecutionStrategy();

            await strategy.ExecuteAsync(async () =>
            {
                using var transaction = await DbContext.Database.BeginTransactionAsync();

                // 记录方法名
                var methodName = LogHelper.FormatMethodName(context.ServiceMethod);

                try
                {
                    Logger?.LogDebug("开始事务：{Method}", methodName);

                    await next(context);

                    await transaction.CommitAsync();

                    Logger?.LogDebug("提交事务：{Method}", methodName);
                }
                catch (Exception ex)
                {
                    Logger?.LogWarning("提交事务失败，开始回滚事务：{Method}", methodName);

                    await transaction.RollbackAsync();

                    Logger?.LogWarning("提交事务失败，回滚事务完成：{Method}", methodName);

                    Logger?.LogError("提交事务失败，事务管理发生异常：{Method}", methodName);

                    throw new RepositoryException("提交事务失败，事务管理出现未知错误。", ex);
                }
            });
        }
    }
}
