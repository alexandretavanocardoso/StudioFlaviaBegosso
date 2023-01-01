using studioFlaviaBegosso.Infra.Data.Repositorys;
using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Domain.Model;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace StudioFlaviaBegosso.Infra.Data.Repositorys.Adm
{
    public class GalleryRepository : BaseRepository<GalleryModel>, IGalleryRepository
    {
        public GalleryRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext) : base(studioFlaviaBegossoContext) {}

        public async Task<List<GalleryModel>> GetAllGallery()
            => await SelectListAsync();

        public async Task<GalleryModel> GetGallery(Guid id)
            => await SelectAsync(id);

        public async Task<bool> InsertGallery(GalleryModel gallery)
        {
            gallery.DateCreation = DateTime.Now;
            gallery.CreatedBy = "Flávia Alessandra Begosso";
            GalleryModel result = await InsertAsync(gallery);
            if (result == null) return false;

            return true;
        }

        public async Task<bool> UpdateGallery(Guid id, GalleryModel gallery)
        {
            gallery.DateUpdate = DateTime.Now;
            gallery.EditBy = "Flávia Alessandra Begosso";
            GalleryModel result = await UpdateAsync(id, gallery);
            if (result == null) return false;

            return true;
        }

        public async Task<bool> DeleteGallery(Guid id)
        {
            bool result = await DeleteAsync(id);
            if (!result) return false;

            return true;
        }
    }
}
