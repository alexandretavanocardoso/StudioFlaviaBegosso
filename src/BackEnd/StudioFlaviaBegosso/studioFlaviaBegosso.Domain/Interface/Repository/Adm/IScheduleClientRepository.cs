using studioFlaviaBegosso.Domain.Model.Adm;

namespace studioFlaviaBegosso.Domain.Interface.Repository.Adm;
public interface IScheduleClientRepository
{
    Task<bool> InsertMarkSchedule(ScheduleClientModel schedule);
    Task<bool> UpdateMarkSchedule(Guid id, ScheduleClientModel schedule);
}
