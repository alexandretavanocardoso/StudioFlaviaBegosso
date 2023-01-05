using studioFlaviaBegosso.Domain.Dto.Authentication;
using StudioFlaviaBegosso.Domain.Interface.Service.Authentication;

namespace StudioFlaviaBegosso.Authentication
{
    [Route("api/v1/[controller]")]
    [ApiExplorerSettings(IgnoreApi = false)]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly ITokenService _tokenService;
        private readonly ILogger<AuthenticationDto> _logger;
        private readonly UserManager<IdentityUser> _userManager;

        public TokenController(ITokenService tokenService, 
                               ILogger<AuthenticationDto> logger,
                               UserManager<IdentityUser> userManager)
        {
            _tokenService = tokenService;
            _logger = logger;
            _userManager = userManager;
        }

        [HttpPost("generate-token")]
        public async Task<ActionResult> GenerateToken([FromBody] AuthenticationDto authentication)
        {
            string token = await _tokenService.GenerateTokenAsync(authentication, _userManager);
            if (string.IsNullOrEmpty(token))
            {
                _logger.LogError("Token inválido. Method: generate-token");
                return BadRequest("Autenticação inválida");
            }

            return Created("Token", "TOKEN: Bearer "+token);
        }
    }
}
