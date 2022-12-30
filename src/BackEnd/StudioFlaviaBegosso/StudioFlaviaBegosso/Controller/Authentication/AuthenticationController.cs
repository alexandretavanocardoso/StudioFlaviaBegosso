using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using studioFlaviaBegosso.Domain.Dto.Authentication;
using StudioFlaviaBegosso.Domain.Interface.Service.Authentication;

namespace StudioFlaviaBegosso.EndPoints.Authentication
{
    [Route("api/v1/[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly UserManager<IdentityUser> _userManager;

        public AuthenticationController(IAuthenticationService authenticationService, UserManager<IdentityUser> userManager)
        {
            _authenticationService = authenticationService;
            _userManager = userManager;
        }

        [HttpPost("insert-user")]
        public async Task<ActionResult<bool>> InsertUser([FromBody] AuthenticationDto authentication)
        {
            bool auth = await _authenticationService.InsertUserAsync(authentication, _userManager);
            if (!auth)
                return BadRequest("Autenticação invalida");

            return Created("Sucesso!", true);
        }
    }
}
