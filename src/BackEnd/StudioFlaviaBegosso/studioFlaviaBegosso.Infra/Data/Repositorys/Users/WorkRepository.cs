using studioFlaviaBegosso.Domain.Interface.Repository.Users;
using StudioFlaviaBegosso.Domain.Interface.Repository;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace studioFlaviaBegosso.Infra.Data.Repositorys.Users
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
