using studioFlaviaBegosso.Domain.Interface.Repository.Users;
using StudioFlaviaBegosso.Domain.Model;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace studioFlaviaBegosso.Infra.Data.Repositorys.Users
{
    public class WorkRepository : BaseRepository<WorkModel>, IWorkRepository
    {
        public WorkRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext) : base(studioFlaviaBegossoContext) { }

        public async Task<List<WorkModel>> GetAllWork()
        {
            return await SelectListAsync();
        }

        public async Task<WorkModel> GetWork(Guid id)
        {
            return await SelectAsync(id);
        }
    }
}
