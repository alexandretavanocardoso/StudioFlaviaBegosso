using studioFlaviaBegosso.Domain.Model.Adm;

namespace studioFlaviaBegosso.Domain.Interface.Repository.Adm;
public interface IScheduleClientHistoryRepository
{
    Task<bool> InsertMarkScheduleHistory(ScheduleClientHistoryModel schedule, bool isUpdate, bool isInsert);
}
