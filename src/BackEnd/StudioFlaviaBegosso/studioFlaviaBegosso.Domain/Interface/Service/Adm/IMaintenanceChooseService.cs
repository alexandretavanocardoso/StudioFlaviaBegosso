using studioFlaviaBegosso.Domain.Dto.Adm;

namespace StudioFlaviaBegosso.Domain.Interface.Service.Adm;

public interface IMaintenanceChooseService
{
    Task<List<MaintenanceChooseDto>> GetAllMaintenanceChooseAsync();
    Task<MaintenanceChooseDto> GetMaintenanceChooseAsync(Guid id);
    Task<bool> InsertMaintenanceChooseAsync(MaintenanceChooseDto maintenanceChoose);
    Task<bool> UpdateMaintenanceChooseAsync(Guid id, MaintenanceChooseDto maintenanceChoose);
    Task<bool> DeleteMaintenanceChooseAsync(Guid id);
}
