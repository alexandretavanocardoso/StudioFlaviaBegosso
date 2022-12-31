using studioFlaviaBegosso.Domain.Dto.Email;

namespace studioFlaviaBegosso.Domain.Interface.Service.Email;
public interface IEmailService
{
    Task<List<EmailDto>> GetAllEmailAsync();
    Task<EmailDto> GetEmailAsync(Guid id);
    Task<bool> SendEmailAsync(EmailDto email);
    Task<bool> DeleteEmailAsync(Guid id);
}
