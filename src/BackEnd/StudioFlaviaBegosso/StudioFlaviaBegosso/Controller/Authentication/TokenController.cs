using Microsoft.AspNetCore.Mvc;
using StudioFlaviaBegosso.Domain.Interface.Service.Authentication;

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
    }
}
