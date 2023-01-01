using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using studioFlaviaBegosso.Domain.Dto.Authentication;
using StudioFlaviaBegosso.Domain.Interface.Service.Authentication;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace StudioFlaviaBegosso.Business.Services.Authentication;

public class TokenService : ITokenService
{
    private readonly IConfiguration _configuration;

    public TokenService(IConfiguration configuration) { _configuration = configuration; }

    public async Task<string> GenerateTokenAsync(AuthenticationDto authentication, UserManager<IdentityUser> userManager)
    {
        IdentityUser user = await userManager.FindByEmailAsync(authentication.Email);
        if (user == null) return string.Empty;

        if (!userManager.CheckPasswordAsync(user, authentication.Password).Result) return string.Empty;

        return GerarToken(user, authentication, userManager);
    }

    private string GerarToken(IdentityUser user, AuthenticationDto authentication, UserManager<IdentityUser> userManager)
    {
        IList<Claim> claim = userManager.GetClaimsAsync(user).Result;
        ClaimsIdentity subject = new ClaimsIdentity(new Claim[]
            {
                new Claim(ClaimTypes.Email, authentication.Email)
            });
        subject.AddClaims(claim);

        byte[] key = Encoding.ASCII.GetBytes(_configuration["JwtBearerToken:SecretKey"]);
        SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor {
            Subject = subject,
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            Audience = _configuration["JwtBearerToken:Audience"],
            Issuer = _configuration["JwtBearerToken:Issuer"],
            Expires = DateTime.UtcNow.AddMinutes(60)
        };

        JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
        SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

        return tokenHandler.WriteToken(token);
    }
}
