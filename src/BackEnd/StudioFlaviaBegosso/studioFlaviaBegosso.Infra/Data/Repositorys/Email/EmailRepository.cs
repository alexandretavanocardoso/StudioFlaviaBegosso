using studioFlaviaBegosso.Domain.Interface.Repository.Email;
using studioFlaviaBegosso.Domain.Model;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace studioFlaviaBegosso.Infra.Data.Repositorys.Email
{
    public class EmailRepository : BaseRepository<EmailModel>, IEmailRepository
    {
        public EmailRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext) : base(studioFlaviaBegossoContext) {}

        public async Task<List<EmailModel>> GetAllEmail()
            => await SelectListAsync();

        public async Task<EmailModel> GetEmail(Guid id)
            => await SelectAsync(id);

        public async Task<bool> InsertEmail(EmailModel blog)
        {
            EmailModel result = await InsertAsync(blog);
            if (result == null) return false;

            return true;
        }

        public async Task<bool> DeleteEmail(Guid id)
        {
            bool result = await DeleteAsync(id);
            if (!result) return false;

            return true;
        }
    }
}
