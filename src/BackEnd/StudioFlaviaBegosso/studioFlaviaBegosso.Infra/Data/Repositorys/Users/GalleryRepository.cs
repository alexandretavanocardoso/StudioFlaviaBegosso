using studioFlaviaBegosso.Domain.Interface.Repository.Users;
using StudioFlaviaBegosso.Domain.Model;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace studioFlaviaBegosso.Infra.Data.Repositorys.Users
{
    public class GalleryRepository : BaseRepository<GalleryModel>, IGalleryRepository
    {
        public GalleryRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext) : base(studioFlaviaBegossoContext) { }

        public async Task<List<GalleryModel>> GetAllGallery()
        {
            return await SelectListAsync();
        }

        public async Task<GalleryModel> GetGallery(Guid id)
        {
            return await SelectAsync(id);
        }
    }
}
