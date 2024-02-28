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
    // ���ڶ���API���������ú�����
    public class Startup
    {
        // ��ȡӦ�ó��������ļ�
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // DI ��������ʵ������ע��Ĺ��ߣ����𴴽����󣬽�����ע��������ϵ

        // ����ע�룺ʵ�ֿ��Ʒ�ת��IOC����ʹ������ע���һ���������������Ҫ��������
        // ������ֱ�Ӵ���������Щ����ͨ��ͨ������Ĺ��캯��������ĳ���趨��������

        // ������Ӻ�����Ӧ�ó���ķ���
        // ������ע�ᵽ DI ������ʹ�������Ӧ�ó����п���ͨ������ע��ķ�ʽʹ������
        public void ConfigureServices(IServiceCollection services)
        {
            // ��ӿ���������
            services.AddControllers(options =>
            {
                // ���������ý�����Ͳ���֧��ʱ���� HTTP 406 Not Acceptable ״̬��
                options.ReturnHttpNotAcceptable = true;
            })
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                })
                .AddXmlDataContractSerializerFormatters() // ��Ӷ�������� application/xml ��֧��
                .ConfigureApiBehaviorOptions(options =>   // �����֤ʧ��ʱ(API���ܵ�ģ��״̬��Ч)���ص���Ӧ�����Զ���
                {
                    options.InvalidModelStateResponseFactory = context =>
                    {
                        // ��׼��Ӧ��ʽ����
                        var validationProblemDetail = new ValidationProblemDetails(context.ModelState)
                        {
                            Title = "������֤ʧ�ܡ�",
                            Status = StatusCodes.Status422UnprocessableEntity,
                            Detail = "����Ĳ�����Ч���ʽ�������������롣",
                            Instance = context.HttpContext.Request.Path,
                        };
                        validationProblemDetail.Extensions.Add("traceId", context.HttpContext.TraceIdentifier);

                        return new UnprocessableEntityObjectResult(validationProblemDetail)
                        {
                            ContentTypes = { "application/problem+json; charset=utf-8" }
                        };
                    };
                });
            //.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<TouristRouteUpdateDtoValidator>()); // ע��FluentValidation��֤��

            // ������ݿ������Ķ���
            services.AddDbContext<FakeXieChengContext>(options =>
            {
                // ���ݿ�����
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });

            // ���Swagger����
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "FakeXieCheng API",
                    Description = "An ASP.NET Core API"
                });
                // ע�⣺���������ͨ��c.AddSecurityDefinition�ȷ�����Ӱ�ȫ���壬������API��Ҫ��ȫ��(Token��֤��)
            });

            // ���AspectCore����
            services.ConfigureDynamicProxy(config =>
            {
                // ��ȫ��������Ӧ�������к�׺Ϊ Service ����
                config.Interceptors.AddTyped<GeneralServiceInterceptor>(Predicates.ForService("*Service"));
                config.Interceptors.AddTyped<GeneralRepositoryInterceptor>(Predicates.ForService("*Repository"));
            });

            // ��Ӷ���ӳ�����
            // ���������Ҳ�ɨ��Ӧ�ó���ǰ���м��ص����г��򼯣���Ѱ�� AutoMapper �������ࣨͨ���Ǽ̳��� Profile ����ࣩ
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            // Transient ÿ���ӷ���������ȡ����ʱ�����ᴴ���÷������ʵ��
            // Singleton ����Ӧ�ó�������������ֻ����һ��
            // Scoped ÿ������������ֻ����һ��

            // ������ݲֿ����
            services.AddScoped<ITouristRouteRepository, TouristRouteRepository>();
            services.AddScoped<ITouristRoutePictureRepository, TouristRoutePictureRepository>();

            // ��ӷ�������
            services.AddScoped<ITouristRouteService, TouristRouteService>();
            services.AddScoped<ITouristRoutePictureService, TouristRoutePictureService>();
            services.AddScoped<IAuthenticateService, AuthenticateService>();
        }


        // ������ʱ���ã��������� HTTP ����ܵ�
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            // ������Ϊ��������ʱ����
            if (env.IsDevelopment())
            {
                // ע�Ὺ�������쳣�����м��
                app.UseDeveloperExceptionPage();

                // ע��Swagger����
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FakeXieCheng API V1"));
            }
            else
            {
                // ע�� ExceptionHandler �м������ȫ���쳣
                app.UseExceptionHandler(appBuilder =>
                {
                    appBuilder.Run(async context =>
                    {
                        var contextFeature = context.Features.Get<IExceptionHandlerFeature>();

                        if (contextFeature != null)
                        {
                            logger.LogError(contextFeature.Error, "ExceptionHandler����δ�����쳣��");

                            context.Response.StatusCode = 500; // �ڲ�����������
                            context.Response.ContentType = "application/json";
                            var errorMessage = "�������ڲ��������Ժ����ԡ�";

                            if (contextFeature.Error is ControllerException ex)
                            {
                                context.Response.StatusCode = ex.StatusCode;
                                errorMessage = ex.Message;
                            }

                            var responseJson = JsonConvert.SerializeObject(new
                            {
                                // ��Ҫ��ǰ����������Ϣ��ʽһ��
                                code = context.Response.StatusCode,
                                msg = errorMessage
                            });
                            await context.Response.WriteAsync(responseJson);
                        }
                    });
                });
            }

            // ע��Serilog��������־��¼�м��
            app.UseSerilogRequestLogging();

            // ע���������־�м��
            app.UseControllerLogging();

            // ע��·���м��
            app.UseRouting();

            // ע���ս��·���м��
            app.UseEndpoints(endpoints =>
            {
                // �� HTTP ����·�ɵ�Ӧ�ó����ж����Controller����
                endpoints.MapControllers();
            });
        }
    }
}
