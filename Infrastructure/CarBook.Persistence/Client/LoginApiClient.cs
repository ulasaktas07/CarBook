using CarBook.Aplication.Interfaces.ApiConsume;
using CarBook.Dto.LoginDtos;
using CarBook.WebUI.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

namespace CarBook.Persistence.Client
{
    public class LoginApiClient : ILoginApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoginApiClient(IHttpClientFactory httpClientFactory, IHttpContextAccessor httpContextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<JwtResponseModel> SendCreateLoginAsync(CreateLoginRequest createLoginRequest)
        {
            var client = _httpClientFactory.CreateClient();

            var jsonContent = JsonSerializer.Serialize(createLoginRequest);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await client.PostAsync("https://localhost:7274/api/Login", content);
            if (!response.IsSuccessStatusCode)
                return null!;

            var jsonData = await response.Content.ReadAsStringAsync();

            var tokenModel = JsonSerializer.Deserialize<JwtResponseModel>(jsonData, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            });

            if (tokenModel?.Token != null)
            {
                var handler = new JwtSecurityTokenHandler();
                var token = handler.ReadJwtToken(tokenModel.Token);
                var claims = token.Claims.ToList();

                claims.Add(new Claim("accessToken", tokenModel.Token));

                var claimsIdentity = new ClaimsIdentity(claims, JwtBearerDefaults.AuthenticationScheme);
                var authProps = new AuthenticationProperties
                {
                    ExpiresUtc = tokenModel.ExpireDate.ToUniversalTime(),
                    IsPersistent = true
                };

                var httpContext = _httpContextAccessor.HttpContext;
                if (httpContext != null)
                {
                    await httpContext.SignInAsync(JwtBearerDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProps);
                }
            }

            return tokenModel!;
        }
    }
}