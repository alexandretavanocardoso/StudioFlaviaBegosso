using studioFlaviaBegosso.Domain.Dto;
using studioFlaviaBegosso.Domain.Interface.Repository.Users;
using studioFlaviaBegosso.Domain.Interface.Service.Users;
using StudioFlaviaBegosso.Domain.Model;

namespace studioFlaviaBegosso.Business.Services.Users;

public class BlogService : IBlogService
{
    private readonly IBlogRepository _blogRepository;
    private readonly IMapper _mapper;

    public BlogService(IBlogRepository blogRepository, IMapper mapper)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
    }

    public async Task<List<BlogDto>> GetAllBlogAsync()
    {
        List<BlogModel> blogModel = await _blogRepository.GetAllBlogAsync();
        return _mapper.Map<List<BlogDto>>(blogModel);
    }

    public async Task<BlogDto> GetBlogAsync(Guid id)
    {
        BlogModel blogModel = await _blogRepository.GetBlogAsync(id);
        return _mapper.Map<BlogDto>(blogModel);
    }
}
