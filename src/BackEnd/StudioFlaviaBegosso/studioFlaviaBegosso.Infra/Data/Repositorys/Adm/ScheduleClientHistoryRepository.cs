using studioFlaviaBegosso.Domain.Interface.Repository.Adm;
using studioFlaviaBegosso.Domain.Model.Adm;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace studioFlaviaBegosso.Infra.Data.Repositorys.Adm
{
    public class ScheduleClientHistoryRepository : BaseRepository<ScheduleClientHistoryModel>, IScheduleClientHistoryRepository
    {
        public ScheduleClientHistoryRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext) : base(studioFlaviaBegossoContext) {}

        public async Task<bool> InsertMarkScheduleHistory(ScheduleClientHistoryModel schedule, bool isUpdate, bool isInsert)
        {
            schedule.DateCreation = DateTime.Now;
            schedule.CreatedBy = "Flávia Alessandra Begosso";
            schedule.IsInsert = isInsert;
            schedule.IsUpdate = isUpdate;
            ScheduleClientHistoryModel result = await InsertAsync(schedule);
            if (result == null) return false;

            return true;
        }
    }
}
