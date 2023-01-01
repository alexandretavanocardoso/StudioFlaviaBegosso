using studioFlaviaBegosso.Domain.Interface.Repository.Users;
using StudioFlaviaBegosso.Domain.Model;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace studioFlaviaBegosso.Infra.Data.Repositorys.Users;

public class BlogRepository : BaseRepository<BlogModel>, IBlogRepository
{
    public BlogRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext) : base(studioFlaviaBegossoContext) { }

    public async Task<List<BlogModel>> GetAllBlogAsync()
        => await SelectListAsync();

    public async Task<BlogModel> GetBlogAsync(Guid id)
        => await SelectAsync(id);
}
