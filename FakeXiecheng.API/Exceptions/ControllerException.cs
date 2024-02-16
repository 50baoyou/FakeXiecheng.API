namespace FakeXiecheng.API.Exceptions
{
    public class ControllerException : Exception
    {
        public int StatusCode { get; private set; }

        // 使用消息和状态码初始化异常
        public ControllerException(int statusCode, string message) : base(message)
        {
            StatusCode = statusCode;
        }

        // 使用消息、状态码和内部异常初始化异常
        public ControllerException(int statusCode, string message, Exception innerException) : base(message, innerException)
        {
            StatusCode = statusCode;
        }
    }
}
