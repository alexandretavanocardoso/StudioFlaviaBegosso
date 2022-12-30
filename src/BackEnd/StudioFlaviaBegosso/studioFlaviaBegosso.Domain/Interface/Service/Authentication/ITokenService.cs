using Microsoft.AspNetCore.Identity;
using studioFlaviaBegosso.Domain.Dto.Authentication;

namespace StudioFlaviaBegosso.Domain.Interface.Service.Authentication;

public interface ITokenService
{
    Task<string> GenerateTokenAsync(AuthenticationDto authentication, UserManager<IdentityUser> userManager);
}
