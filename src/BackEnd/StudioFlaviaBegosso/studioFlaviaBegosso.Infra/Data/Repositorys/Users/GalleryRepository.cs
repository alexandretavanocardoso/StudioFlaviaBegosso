using studioFlaviaBegosso.Domain.Interface.Repository.Users;
using StudioFlaviaBegosso.Domain.Interface.Repository;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace studioFlaviaBegosso.Infra.Data.Repositorys.Users
{
    public class GalleryRepository : IGalleryRepository
    {
        private StudioFlaviaBegossoContext _studioFlaviaBegossoContext;

        public GalleryRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext)
        {
            _studioFlaviaBegossoContext = studioFlaviaBegossoContext;
        }
    }
}
