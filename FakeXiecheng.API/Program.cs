using AspectCore.Extensions.DependencyInjection;
using Serilog;

namespace FakeXiecheng.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Run()���������и���������ʼ�������Կͻ��˵�HTTP����
            CreateHostBuilder(args).Build().Run();
        }

        // ���úʹ���һ������������
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            // ����Ĭ�ϵ�����������
            Host.CreateDefaultBuilder(args)
                // ʹ��Ĭ�� WEB ��������
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // ָ��Ӧ�ó���������
                    webBuilder.UseStartup<Startup>();
                })
                // ע�� Serilog ��־
                .UseSerilog((hostingContext, loggerConfiguration) =>
                {
                    loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration);
                })
                // ע�� AspectCore ��̬������
                .UseServiceProviderFactory(new DynamicProxyServiceProviderFactory());
    }
}
