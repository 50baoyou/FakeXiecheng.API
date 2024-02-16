using System.Reflection;
using System.Text.Json;

namespace FakeXiecheng.API.Helpers
{
    public static class LogHelper
    {
        public static string FormatMethodName(MethodInfo methodInfo)
        {
            return $"{methodInfo.DeclaringType?.FullName}.{methodInfo.Name}";
        }

        public static string FormatMethodParameters(MethodInfo methodInfo, object[] args)
        {
            if (methodInfo == null)
            {
                return "parameters null";
            }

            var parametersInfo = methodInfo.GetParameters();
            var paramDetailsList = new List<string>();

            //使用序列化处理中文
            var serializerOptions = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All) // 确保正确处理中文
            };

            for (int i = 0; i < parametersInfo.Length; i++)
            {
                var paramInfo = parametersInfo[i];
                var arg = args[i];
                string paramDetails;

                if (arg is System.Linq.Expressions.Expression expression)
                {
                    paramDetails = $"{paramInfo.Name} = {arg.ToString}";
                }
                else if (arg != null && arg.GetType().IsClass && arg.GetType() != typeof(string))
                {
                    // 参数是对象（除了string），通过序列化获取其详细信息
                    try
                    {
                        paramDetails = $"{paramInfo.Name} = {JsonSerializer.Serialize(arg, serializerOptions)}";
                    }
                    catch (JsonException)
                    {
                        paramDetails = $"{paramInfo.Name} = [Serialization Error]";
                    }
                }
                else
                {
                    // 基本类型参数或null，直接转换为字符串
                    paramDetails = $"{paramInfo.Name} = {arg}";
                }

                paramDetailsList.Add(paramDetails);
            }

            return string.Join(", ", paramDetailsList);
        }
    }
}
