using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text.Json;

namespace KvalikBlazor.Utils
{
    public static class JwtHelper
    {
        public static string GetUserRoleFromToken(string token)
        {
            try
            {
                var handler = new JwtSecurityTokenHandler();
                var jwtToken = handler.ReadJwtToken(token);

                var role = jwtToken.Claims
                    .FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;

                return role;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при чтении роли из токена: " + ex.Message);
                return null;
            }
        }
    }
}
