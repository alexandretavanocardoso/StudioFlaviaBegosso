using studioFlaviaBegosso.Domain.Dto.Authentication;
using StudioFlaviaBegosso.Domain.Interface.Service.Authentication;

namespace StudioFlaviaBegosso.Authentication
{
    [Route("api/v1/[controller]")]
    [ApiExplorerSettings(IgnoreApi = false)]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly ILogger<AuthenticationDto> _logger;
        private readonly UserManager<IdentityUser> _userManager;

        public AuthenticationController(IAuthenticationService authenticationService, 
                                        ILogger<AuthenticationDto> logger,
                                        UserManager<IdentityUser> userManager)
        {
            _authenticationService = authenticationService;
            _logger = logger;
            _userManager = userManager;
        }

        [HttpPost("insert-user")]
        public async Task<ActionResult<bool>> InsertUser([FromBody] AuthenticationDto authentication)
        {
            bool auth = await _authenticationService.InsertUserAsync(authentication, _userManager);
            if (!auth) {
                _logger.LogError("Usuário inválido. Method: insert-user");
                return BadRequest("Autenticação ínvalida");
            }

            return Created("Sucesso!", true);
        }
    }
}
