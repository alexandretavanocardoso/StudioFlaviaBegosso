using studioFlaviaBegosso.Domain.Model;

namespace studioFlaviaBegosso.Domain.Interface.Repository.Email;
public interface IEmailRepository
{
    Task<List<EmailModel>> GetAllEmail();
    Task<EmailModel> GetEmail(Guid id);
    Task<bool> InsertEmail(EmailModel blog);
    Task<bool> DeleteEmail(Guid id);
}
