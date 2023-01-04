using studioFlaviaBegosso.Domain.Model.Adm;

namespace studioFlaviaBegosso.Domain.Interface.Repository.Adm;
public interface IScheduleClientRepository
{
    Task<List<ScheduleClientModel>> GetAllScheduleClient();
    Task<ScheduleClientModel> GetScheduleClient(Guid id);
    Task<bool> InsertMarkSchedule(ScheduleClientModel schedule);
    Task<bool> UpdateMarkSchedule(Guid id, ScheduleClientModel schedule);
    Task<bool> DeleteMarkSchedule(Guid id);
}
