using AspectCore.Extensions.DependencyInjection;
using Serilog;

namespace FakeXiecheng.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Run()方法则运行该主机并开始监听来自客户端的HTTP请求
            CreateHostBuilder(args).Build().Run();
        }

        // 配置和创建一个主机构建器
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            // 创建默认的主机构建器
            Host.CreateDefaultBuilder(args)
                // 使用默认 WEB 主机配置
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // 指定应用程序启动类
                    webBuilder.UseStartup<Startup>();
                })
                // 注册 Serilog 日志
                .UseSerilog((hostingContext, loggerConfiguration) =>
                {
                    loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration);
                })
                // 注册 AspectCore 动态代理工厂
                .UseServiceProviderFactory(new DynamicProxyServiceProviderFactory());
    }
}
