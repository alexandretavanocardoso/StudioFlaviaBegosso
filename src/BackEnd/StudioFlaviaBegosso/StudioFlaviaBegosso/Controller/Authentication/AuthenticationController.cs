using Microsoft.AspNetCore.Mvc;
using StudioFlaviaBegosso.Domain.Interface.Service.Authentication;

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
    }
}
