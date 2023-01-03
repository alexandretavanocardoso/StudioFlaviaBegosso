using studioFlaviaBegosso.Domain.Model.Adm;
using studioFlaviaBegosso.Infra.Data.Repositorys;
using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace StudioFlaviaBegosso.Infra.Data.Repositorys.Adm;

public class ProcedureRepository : BaseRepository<ProcedureModel>, IProcedureRepository
{
    public ProcedureRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext) : base(studioFlaviaBegossoContext) {}

    public async Task<List<ProcedureModel>> GetAllProcedure()
        => await SelectListAsync();

    public async Task<ProcedureModel> GetProcedure(Guid id)
        => await SelectAsync(id);

    public async Task<bool> InsertProcedure(ProcedureModel procedure)
    {
        procedure.DateCreation = DateTime.Now;
        procedure.CreatedBy = "Flávia Alessandra Begosso";
        ProcedureModel result = await InsertAsync(procedure);
        if (result == null) return false;
        
        return true;
    }

    public async Task<bool> UpdateProcedure(Guid id, ProcedureModel procedure)
    {
        procedure.DateUpdate = DateTime.Now;
        procedure.EditBy = "Flávia Alessandra Begosso";
        ProcedureModel result = await UpdateAsync(id, procedure);
        if (result == null) return false;

        return true;
    }

    public async Task<bool> DeleteProcedure(Guid id)
    {
        bool result = await DeleteAsync(id);
        if (!result) return false;

        return true;
    }
}
