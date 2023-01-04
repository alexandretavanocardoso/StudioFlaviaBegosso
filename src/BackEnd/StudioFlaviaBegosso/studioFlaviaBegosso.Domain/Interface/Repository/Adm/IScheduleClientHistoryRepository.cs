using studioFlaviaBegosso.Domain.Model.Adm;

namespace studioFlaviaBegosso.Domain.Interface.Repository.Adm;
public interface IScheduleClientHistoryRepository
{
    Task<List<ScheduleClientHistoryModel>> GetAllScheduleHistoryClient();
    Task<ScheduleClientHistoryModel> GetScheduleHistoryClient(Guid id);
    Task<bool> InsertMarkScheduleHistory(ScheduleClientHistoryModel schedule, bool isUpdate, bool isInsert);
    Task<bool> DeleteMarkScheduleHistory(Guid id);
}
