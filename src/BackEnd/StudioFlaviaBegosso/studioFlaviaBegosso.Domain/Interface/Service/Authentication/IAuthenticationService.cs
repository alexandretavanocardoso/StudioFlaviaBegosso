using Microsoft.AspNetCore.Identity;
using StudioFlaviaBegosso.Domain.Request.Authentication;

namespace StudioFlaviaBegosso.Domain.Interface.Service.Authentication;

public interface IAuthenticationService
{
    bool InsertUserAsync(AuthenticationRequest authentication, UserManager<IdentityUser> userManager);
}
