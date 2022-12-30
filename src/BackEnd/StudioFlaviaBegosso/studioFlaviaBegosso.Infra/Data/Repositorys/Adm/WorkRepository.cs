using studioFlaviaBegosso.Infra.Data.Repositorys;
using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Domain.Model;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace StudioFlaviaBegosso.Infra.Data.Repositorys.Adm
{
    public class WorkRepository : BaseRepository<WorkModel>, IWorkRepository
    {
        public WorkRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext) : base(studioFlaviaBegossoContext) {}

        public async Task<List<WorkModel>> GetAllWork()
        {
            return await SelectListAsync();
        }

        public async Task<WorkModel> GetWork(Guid id)
        {
            return await SelectAsync(id);
        }

        public async Task<bool> InsertWork(WorkModel work)
        {
            var result = await InsertAsync(work);
            if (result == null) return false;

            return true;
        }

        public async Task<bool> UpdateWork(Guid id, WorkModel work)
        {
            var result = await UpdateAsync(id, work);
            if (result == null) return false;

            return true;
        }

        public async Task<bool> DeleteWork(Guid id)
        {
            var result = await DeleteAsync(id);
            if (!result) return false;

            return true;
        }
    }
}
