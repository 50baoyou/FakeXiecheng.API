
using FakeXiecheng.API.Exceptions;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace FakeXiecheng.API.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly IConfiguration _configuration;

        public AuthenticateService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string CreateJwtToken(string email)
        {
            // header
            var signingAlgorithm = SecurityAlgorithms.HmacSha256;
            // payload
            var cliaims = new[]
            {
                // sub
                new Claim(JwtRegisteredClaimNames.Sub,email)
            };
            // signiture
            //_configuration.GetSection("Authentication:SecretKey").Value;
            var secretKey = _configuration["Authentication:SecretKey"];
            if (string.IsNullOrEmpty(secretKey))
            {
                throw new ServiceException("获取 SecretKey 失败。");
            }

            var secretKeyToByte = Encoding.UTF8.GetBytes(secretKey);
            var signingKey = new SymmetricSecurityKey(secretKeyToByte);
            var appSigningCredentials = new SigningCredentials(signingKey, signingAlgorithm);

            // 创建 JWT Token
            var jwtToken = new JwtSecurityToken(
                issuer: _configuration["Authentication:Issuer"],
                audience: _configuration["Authentication:Audience"],
                cliaims,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddDays(1),
                signingCredentials: appSigningCredentials
                );

            return new JwtSecurityTokenHandler().WriteToken(jwtToken);
        }

        public Task<bool> TryAuthenticate(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
