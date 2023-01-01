using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using studioFlaviaBegosso.Domain.Dto.Email;
using studioFlaviaBegosso.Domain.Interface.Service.Email;

namespace StudioFlaviaBegosso.EndPoints.Authentication
{
    [Route("api/v1/email/[controller]")]
    [ApiExplorerSettings(IgnoreApi = false)]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<List<EmailDto>>> GetAllBlog()
            => await _emailService.GetAllEmailAsync();

        [HttpGet("get/{id:Guid}")]
        public async Task<ActionResult<EmailDto>> GetBlog(Guid id)
            => await _emailService.GetEmailAsync(id);

        [HttpPost("send-email")]
        public async Task<ActionResult<bool>> SendEmail([FromBody] EmailDto email)
            => await _emailService.SendEmailAsync(email);

        [Authorize(Policy = "AdminPolicy")]
        [HttpDelete("delete-email")]
        public async Task<ActionResult<bool>> DeleteBlog(Guid id)
            => await _emailService.DeleteEmailAsync(id);
    }
}
