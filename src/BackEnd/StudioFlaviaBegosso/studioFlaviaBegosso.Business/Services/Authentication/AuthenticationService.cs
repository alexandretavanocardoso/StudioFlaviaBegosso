using Microsoft.AspNetCore.Identity;
using StudioFlaviaBegosso.Domain.Interface.Service.Authentication;
using StudioFlaviaBegosso.Domain.Request.Authentication;
using System.Security.Claims;

namespace StudioFlaviaBegosso.Business.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationService() {}

    public bool InsertUserAsync(AuthenticationRequest authentication, UserManager<IdentityUser> userManager)
    {
        IdentityUser user = new IdentityUser()
        {
            Email = authentication.Email,
            UserName = authentication.Email
        };

        IdentityResult result = userManager.CreateAsync(user, authentication.Password).Result;
        if(!result.Succeeded) return false;

        IdentityResult claim = userManager.AddClaimAsync(user, new Claim("AdminClaim", user.Email)).Result;
        if (!claim.Succeeded) return false;

        return true;
    }
}
