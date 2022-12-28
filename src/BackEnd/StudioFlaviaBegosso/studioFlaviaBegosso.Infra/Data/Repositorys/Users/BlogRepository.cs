using studioFlaviaBegosso.Domain.Interface.Repository.Users;
using StudioFlaviaBegosso.Domain.Interface.Repository;
using StudioFlaviaBegosso.Infra.Data.Context;

namespace studioFlaviaBegosso.Infra.Data.Repositorys.Users;

public class BlogRepository : IBlogRepository
{
    private StudioFlaviaBegossoContext _studioFlaviaBegossoContext;

    public BlogRepository(StudioFlaviaBegossoContext studioFlaviaBegossoContext)
    {
        _studioFlaviaBegossoContext = studioFlaviaBegossoContext;
    }
}
