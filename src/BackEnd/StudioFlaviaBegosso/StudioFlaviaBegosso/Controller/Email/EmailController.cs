using Microsoft.AspNetCore.Mvc;
using studioFlaviaBegosso.Domain.Dto.Email;
using studioFlaviaBegosso.Domain.Interface.Service.Email;

namespace StudioFlaviaBegosso.EndPoints.Authentication
{
    [Route("api/v1/[controller]")]
    [ApiExplorerSettings(IgnoreApi = true)]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost("enviar-email")]
        public async Task<ActionResult<bool>> EnviarEmail([FromBody] EmailDto email)
        {
            return Created("Sucesso!", true);
        }

        [HttpPost("responder-email")]
        public async Task<ActionResult<bool>> ResponderEmail([FromBody] EmailDto email)
        {
            return Created("Sucesso!", true);
        }
    }
}
