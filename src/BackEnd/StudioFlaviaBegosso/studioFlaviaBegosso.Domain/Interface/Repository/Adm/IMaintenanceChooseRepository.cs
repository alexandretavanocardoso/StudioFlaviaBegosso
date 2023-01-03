using studioFlaviaBegosso.Domain.Model.Adm;

namespace StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
public interface IMaintenanceChooseRepository
{
    Task<List<MaintenanceChooseModel>> GetAllMaintenanceChoose();
    Task<MaintenanceChooseModel> GetMaintenanceChoose(Guid id);
    Task<bool> InsertMaintenanceChoose(MaintenanceChooseModel maintenanceChoose);
    Task<bool> UpdateMaintenanceChoose(Guid id, MaintenanceChooseModel maintenanceChoose);
    Task<bool> DeleteMaintenanceChoose(Guid id);
}
