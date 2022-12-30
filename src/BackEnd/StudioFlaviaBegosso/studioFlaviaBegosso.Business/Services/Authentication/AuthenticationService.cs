using Microsoft.AspNetCore.Identity;
using studioFlaviaBegosso.Domain.Dto.Authentication;
using StudioFlaviaBegosso.Domain.Interface.Service.Authentication;
using System.Security.Claims;

namespace StudioFlaviaBegosso.Business.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationService() {}

    public async Task<bool> InsertUserAsync(AuthenticationDto authentication, UserManager<IdentityUser> userManager)
    {
        IdentityUser user = new IdentityUser()
        {
            Email = authentication.Email,
            UserName = authentication.Email
        };

        IdentityResult result = await userManager.CreateAsync(user, authentication.Password);
        if(!result.Succeeded) return false;

        IdentityResult claim = await userManager.AddClaimAsync(user, new Claim("AdminClaim", user.Email));
        if (!claim.Succeeded) return false;

        return true;
    }
}
