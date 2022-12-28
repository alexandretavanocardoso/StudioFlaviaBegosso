using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace StudioFlaviaBegosso.Infra.Data.Repositorys.Adm
{
    public class WorkRepository : IWorkRepository
    {
        private StudioFlaviaBegossoContext _studioFlaviaBegossoContext;

        public WorkRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext)
        {
            _studioFlaviaBegossoContext = studioFlaviaBegossoContext;
        }
    }
}
