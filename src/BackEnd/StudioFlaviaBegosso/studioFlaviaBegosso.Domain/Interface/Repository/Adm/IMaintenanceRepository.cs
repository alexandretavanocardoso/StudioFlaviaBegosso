using studioFlaviaBegosso.Domain.Model.Adm;

namespace StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
public interface IMaintenanceRepository
{
    Task<List<MaintenanceModel>> GetAllMaintenance();
    Task<MaintenanceModel> GetMaintenance(Guid id);
    Task<bool> InsertMaintenance(MaintenanceModel maintenance);
    Task<bool> UpdateMaintenance(Guid id, MaintenanceModel maintenance);
    Task<bool> DeleteMaintenance(Guid id);
}
