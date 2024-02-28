namespace FakeXiecheng.API.Services
{
    public interface IAuthenticateService
    {
        string CreateJwtToken(string email);

        Task<bool> TryAuthenticate(string email, string password);
    }
}
