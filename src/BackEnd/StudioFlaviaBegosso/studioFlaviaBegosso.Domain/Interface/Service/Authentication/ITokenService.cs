using Microsoft.AspNetCore.Identity;
using StudioFlaviaBegosso.Domain.Request.Authentication;

namespace StudioFlaviaBegosso.Domain.Interface.Service.Authentication;

public interface ITokenService
{
    string GenerateTokenAsync(AuthenticationRequest authentication, UserManager<IdentityUser> userManager);
}
