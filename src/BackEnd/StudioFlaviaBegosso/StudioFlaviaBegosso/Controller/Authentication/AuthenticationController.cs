using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudioFlaviaBegosso.Domain.Interface.Service.Authentication;
using StudioFlaviaBegosso.Domain.Request.Authentication;

namespace StudioFlaviaBegosso.EndPoints.Authentication
{
    [Route("api/authentication/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("insert-user")]
        public IResult InsertUser(AuthenticationRequest authentication, UserManager<IdentityUser> userManager)
        {
            bool auth = _authenticationService.InsertUserAsync(authentication, userManager);
            if (!auth)
                return Results.BadRequest("Autenticação invalida");

            return Results.Created("Sucesso!", true);
        }
    }
}
