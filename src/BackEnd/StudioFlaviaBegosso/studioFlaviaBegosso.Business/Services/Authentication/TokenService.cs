using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using StudioFlaviaBegosso.Domain.Interface.Service.Authentication;
using StudioFlaviaBegosso.Domain.Request.Authentication;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace StudioFlaviaBegosso.Business.Services.Authentication;

public class TokenService : ITokenService
{
    private readonly IConfiguration _configuration;

    public TokenService() { }

    public string GenerateTokenAsync(AuthenticationRequest authentication, UserManager<IdentityUser> userManager)
    {
        IdentityUser user = userManager.FindByEmailAsync(authentication.Email).Result;
        if (user == null) return "";

        if (!userManager.CheckPasswordAsync(user, authentication.Password).Result) 
            return "";

        return GerarToken(user, authentication, userManager);
    }


    private string GerarToken(IdentityUser user, AuthenticationRequest authentication, UserManager<IdentityUser> userManager)
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
