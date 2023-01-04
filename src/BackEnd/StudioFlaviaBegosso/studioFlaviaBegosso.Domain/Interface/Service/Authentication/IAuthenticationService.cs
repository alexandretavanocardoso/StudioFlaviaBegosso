using studioFlaviaBegosso.Domain.Dto.Authentication;

namespace StudioFlaviaBegosso.Domain.Interface.Service.Authentication;

public interface IAuthenticationService
{
    Task<bool> InsertUserAsync(AuthenticationDto authentication, UserManager<IdentityUser> userManager);
}
