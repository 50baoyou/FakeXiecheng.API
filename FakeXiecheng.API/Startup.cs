using AspectCore.Configuration;
using AspectCore.Extensions.DependencyInjection;
using FakeXiecheng.API.Database;
using FakeXiecheng.API.Exceptions;
using FakeXiecheng.API.Helpers;
using FakeXiecheng.API.Interceptors;
using FakeXiecheng.API.Repositories;
using FakeXiecheng.API.Services;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Serilog;

namespace FakeXiecheng.API
{
    // 用于定义API的所有设置和配置
    public class Startup
    {
        // 读取应用程序配置文件
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // DI 容器：是实现依赖注入的工具，负责创建对象，解析并注入依赖关系

        // 依赖注入：实现控制反转（IOC），使用依赖注入后，一个类会声明它所需要的依赖，
        // 而不是直接创建它。这些依赖通常通过该类的构造函数，或者某个设定方法传入

        // 用于添加和配置应用程序的服务
        // 将服务注册到 DI 容器，使得在你的应用程序中可以通过依赖注入的方式使用它们
        public void ConfigureServices(IServiceCollection services)
        {
            // 添加控制器服务
            services.AddControllers(options =>
            {
                // 设置请求的媒体类型不被支持时返回 HTTP 406 Not Acceptable 状态码
                options.ReturnHttpNotAcceptable = true;
            })
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                })
                .AddXmlDataContractSerializerFormatters() // 添加对请求参数 application/xml 的支持
                .ConfigureApiBehaviorOptions(options =>   // 针对验证失败时(API接受的模型状态无效)返回的响应进行自定义
                {
                    options.InvalidModelStateResponseFactory = context =>
                    {
                        // 标准响应格式对象
                        var validationProblemDetail = new ValidationProblemDetails(context.ModelState)
                        {
                            Title = "数据验证失败。",
                            Status = StatusCodes.Status422UnprocessableEntity,
                            Detail = "输入的参数无效或格式错误，请重新输入。",
                            Instance = context.HttpContext.Request.Path,
                        };
                        validationProblemDetail.Extensions.Add("traceId", context.HttpContext.TraceIdentifier);

                        return new UnprocessableEntityObjectResult(validationProblemDetail)
                        {
                            ContentTypes = { "application/problem+json; charset=utf-8" }
                        };
                    };
                });
            //.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<TouristRouteUpdateDtoValidator>()); // 注册FluentValidation验证器

            // 添加数据库上下文对象
            services.AddDbContext<FakeXieChengContext>(options =>
            {
                // 数据库配置
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            // 添加Swagger服务
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "FakeXieCheng API",
                    Description = "An ASP.NET Core API"
                });
                // 注意：在这里可以通过c.AddSecurityDefinition等方法添加安全定义，如果你的API需要安全性(Token认证等)
            });

            // 添加AspectCore服务
            services.ConfigureDynamicProxy(config =>
            {
                // 将全局拦截器应用于所有后缀为 Service 的类
                config.Interceptors.AddTyped<GeneralServiceInterceptor>(Predicates.ForService("*Service"));
                config.Interceptors.AddTyped<GeneralRepositoryInterceptor>(Predicates.ForService("*Repository"));
            });

            // 添加对象映射服务
            // 参数：查找并扫描应用程序当前域中加载的所有程序集，以寻找 AutoMapper 的配置类（通常是继承自 Profile 类的类）
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // Transient 每当从服务容器获取服务时，都会创建该服务的新实例
            // Singleton 整个应用程序生命周期内只创建一次
            // Scoped 每个请求周期内只创建一次

            // 添加数据仓库服务
            services.AddScoped<ITouristRouteRepository, TouristRouteRepository>();
            services.AddScoped<ITouristRoutePictureRepository, TouristRoutePictureRepository>();

            // 添加服务层服务
            services.AddScoped<ITouristRouteService, TouristRouteService>();
            services.AddScoped<ITouristRoutePictureService, TouristRoutePictureService>();
            services.AddScoped<IAuthenticateService, AuthenticateService>();
        }


        // 在运行时调用，用于配置 HTTP 请求管道
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            // 当环境为开发环境时启用
            if (env.IsDevelopment())
            {
                // 注册开发环境异常处理中间件
                app.UseDeveloperExceptionPage();

                // 注册Swagger服务
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FakeXieCheng API V1"));
            }
            else
            {
                // 注册 ExceptionHandler 中间件处理全局异常
                app.UseExceptionHandler(appBuilder =>
                {
                    appBuilder.Run(async context =>
                    {
                        var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                        if (contextFeature != null)
                        {
                            logger.LogError(contextFeature.Error, "ExceptionHandler捕获到未处理异常。");

                            context.Response.StatusCode = 500; // 内部服务器错误
                            context.Response.ContentType = "application/json";
                            var errorMessage = "服务器内部错误，请稍后再试。";

                            if (contextFeature.Error is ControllerException ex)
                            {
                                context.Response.StatusCode = ex.StatusCode;
                                errorMessage = ex.Message;
                            }

                            var responseJson = JsonConvert.SerializeObject(new
                            {
                                // 需要和前端期望的信息格式一致
                                code = context.Response.StatusCode,
                                msg = errorMessage
                            });
                            await context.Response.WriteAsync(responseJson);
                        }
                    });
                });
            }

            // 注册Serilog的请求日志记录中间件
            app.UseSerilogRequestLogging();

            // 注册控制器日志中间件
            app.UseControllerLogging();

            // 注册路由中间件
            app.UseRouting();

            // 注册终结点路由中间件
            app.UseEndpoints(endpoints =>
            {
                // 将 HTTP 请求路由到应用程序中定义的Controller操作
                endpoints.MapControllers();
            });
        }
    }
}
