using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using studioFlaviaBegosso.Domain.Dto.Authentication;
using StudioFlaviaBegosso.Domain.Interface.Service.Authentication;

namespace StudioFlaviaBegosso.EndPoints.Authentication
{
    [Route("api/v1/[controller]")]
    [ApiExplorerSettings(IgnoreApi = false)]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly UserManager<IdentityUser> _userManager;

        public TokenController(ITokenService tokenService, UserManager<IdentityUser> userManager)
        {
            _tokenService = tokenService;
            _userManager = userManager;
        }

        [HttpPost("generate-token")]
        public async Task<ActionResult> GenerateToken([FromBody] AuthenticationDto authentication)
        {
            string token = await _tokenService.GenerateTokenAsync(authentication, _userManager);
            if (string.IsNullOrEmpty(token))
                return BadRequest("Autenticação invalida");

            return Created("Token", "TOKEN: Bearer "+token);
        }
    }
}
