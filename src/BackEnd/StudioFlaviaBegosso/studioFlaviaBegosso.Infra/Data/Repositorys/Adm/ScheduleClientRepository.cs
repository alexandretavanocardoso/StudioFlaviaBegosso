using studioFlaviaBegosso.Domain.Interface.Repository.Adm;
using studioFlaviaBegosso.Domain.Model.Adm;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace studioFlaviaBegosso.Infra.Data.Repositorys.Adm
{
    public class ScheduleClientRepository : BaseRepository<ScheduleClientModel>, IScheduleClientRepository
    {
        public ScheduleClientRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext) : base(studioFlaviaBegossoContext)
        {

        }

        public async Task<List<ScheduleClientModel>> GetAllScheduleClient()
            => await SelectListAsync();

        public async Task<ScheduleClientModel> GetScheduleClient(Guid id)
            => await SelectAsync(id);

        public async Task<bool> InsertMarkSchedule(ScheduleClientModel schedule)
        {
            schedule.DateCreation = DateTime.Now;
            schedule.CreatedBy = "Flávia Alessandra Begosso";
            ScheduleClientModel result = await InsertAsync(schedule);
            if (result == null) return false;

            return true;
        }

        public async Task<bool> UpdateMarkSchedule(Guid id, ScheduleClientModel schedule)
        {
            schedule.DateUpdate = DateTime.Now;
            schedule.EditBy = "Flávia Alessandra Begosso";
            ScheduleClientModel result = await UpdateAsync(id, schedule);
            if (result == null) return false;

            return true;
        }

        public async Task<bool> DeleteMarkSchedule(Guid id)
        {
            bool result = await DeleteAsync(id);
            if (!result) return false;

            return true;
        }
    }
}
