using studioFlaviaBegosso.Domain.Model.Adm;
using studioFlaviaBegosso.Infra.Data.Repositorys;
using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace StudioFlaviaBegosso.Infra.Data.Repositorys.Adm;

public class MaintenanceChooseRepository : BaseRepository<MaintenanceChooseModel>, IMaintenanceChooseRepository
{
    public MaintenanceChooseRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext) : base(studioFlaviaBegossoContext) {}

    public async Task<List<MaintenanceChooseModel>> GetAllMaintenanceChoose()
        => await SelectListAsync();

    public async Task<MaintenanceChooseModel> GetMaintenanceChoose(Guid id)
        => await SelectAsync(id);

    public async Task<bool> InsertMaintenanceChoose(MaintenanceChooseModel maintenanceChoose)
    {
        maintenanceChoose.DateCreation = DateTime.Now;
        maintenanceChoose.CreatedBy = "Flávia Alessandra Begosso";
        MaintenanceChooseModel result = await InsertAsync(maintenanceChoose);
        if (result == null) return false;
        
        return true;
    }

    public async Task<bool> UpdateMaintenanceChoose(Guid id, MaintenanceChooseModel maintenanceChoose)
    {
        maintenanceChoose.DateUpdate = DateTime.Now;
        maintenanceChoose.EditBy = "Flávia Alessandra Begosso";
        MaintenanceChooseModel result = await UpdateAsync(id, maintenanceChoose);
        if (result == null) return false;

        return true;
    }

    public async Task<bool> DeleteMaintenanceChoose(Guid id)
    {
        bool result = await DeleteAsync(id);
        if (!result) return false;

        return true;
    }
}
