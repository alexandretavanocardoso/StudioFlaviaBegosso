using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudioFlaviaBegosso.Domain.Interface.Service.Authentication;
using StudioFlaviaBegosso.Domain.Request.Authentication;

namespace StudioFlaviaBegosso.EndPoints.Authentication
{
    [Route("api/authentication/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly ITokenService _tokenService;

        public TokenController(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }

        [HttpPost("generate-token")]
        public IResult GenerateToken(AuthenticationRequest authentication, UserManager<IdentityUser> userManager)
        {
            string auth = _tokenService.GenerateTokenAsync(authentication, userManager);
            if (string.IsNullOrEmpty(auth))
                return Results.BadRequest("Autenticação invalida");

            return Results.Created("Sucesso!", true);
        }
    }
}
