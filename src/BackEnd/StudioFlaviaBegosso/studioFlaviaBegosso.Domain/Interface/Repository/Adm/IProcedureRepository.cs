using studioFlaviaBegosso.Domain.Model.Adm;

namespace StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
public interface IProcedureRepository
{
    Task<List<ProcedureModel>> GetAllProcedure();
    Task<ProcedureModel> GetProcedure(Guid id);
    Task<bool> InsertProcedure(ProcedureModel procedure);
    Task<bool> UpdateProcedure(Guid id, ProcedureModel procedure);
    Task<bool> DeleteProcedure(Guid id);
}
