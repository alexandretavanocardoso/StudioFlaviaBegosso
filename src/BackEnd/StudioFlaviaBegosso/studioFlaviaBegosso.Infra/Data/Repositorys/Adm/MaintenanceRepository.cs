using studioFlaviaBegosso.Domain.Model.Adm;
using studioFlaviaBegosso.Infra.Data.Repositorys;
using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace StudioFlaviaBegosso.Infra.Data.Repositorys.Adm;

public class MaintenanceRepository : BaseRepository<MaintenanceModel>, IMaintenanceRepository
{
    public MaintenanceRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext) : base(studioFlaviaBegossoContext) {}

    public async Task<List<MaintenanceModel>> GetAllMaintenance()
        => await SelectListAsync();

    public async Task<MaintenanceModel> GetMaintenance(Guid id)
        => await SelectAsync(id);

    public async Task<bool> InsertMaintenance(MaintenanceModel maintenance)
    {
        maintenance.DateCreation = DateTime.Now;
        maintenance.CreatedBy = "Flávia Alessandra Begosso";
        MaintenanceModel result = await InsertAsync(maintenance);
        if (result == null) return false;
        
        return true;
    }

    public async Task<bool> UpdateMaintenance(Guid id, MaintenanceModel maintenance)
    {
        maintenance.DateUpdate = DateTime.Now;
        maintenance.EditBy = "Flávia Alessandra Begosso";
        MaintenanceModel result = await UpdateAsync(id, maintenance);
        if (result == null) return false;

        return true;
    }

    public async Task<bool> DeleteMaintenance(Guid id)
    {
        bool result = await DeleteAsync(id);
        if (!result) return false;

        return true;
    }
}
