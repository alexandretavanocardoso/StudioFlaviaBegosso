using studioFlaviaBegosso.Domain.Dto;
using StudioFlaviaBegosso.Domain.Interface.Repository.Adm;
using StudioFlaviaBegosso.Domain.Interface.Service.Adm;
using StudioFlaviaBegosso.Domain.Model;

namespace StudioFlaviaBegosso.Business.Services.Adm;

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
        List<BlogModel> blogModel = await _blogRepository.GetAllBlog();
        return _mapper.Map<List<BlogDto>>(blogModel);
    }

    public async Task<BlogDto> GetBlogAsync(Guid id)
    {
        BlogModel blogModel = await _blogRepository.GetBlog(id);
        return _mapper.Map<BlogDto>(blogModel);
    }

    public async Task<bool> InsertBlogAsync(BlogDto blogRequet)
    {
        blogRequet.Image = ConvertStringToArrayByte(blogRequet);
        BlogModel model = _mapper.Map<BlogModel>(blogRequet);
        return await _blogRepository.InsertBlog(model);
    }

    public async Task<bool> UpdateBlogAsync(Guid id, BlogDto blogRequet)
    {
        blogRequet.Image = ConvertStringToArrayByte(blogRequet);
        BlogModel model = _mapper.Map<BlogModel>(blogRequet);
        return await _blogRepository.UpdateBlog(id, model);
    }

    public async Task<bool> DeleteBlogAsync(Guid id)
        => await _blogRepository.DeleteBlog(id);

    #region[Privados]
    private byte[] ConvertStringToArrayByte(BlogDto blogRequet)
    {
        Regex regex = new Regex(@"^[\w/\:.-]+;base64,");
        string image = regex.Replace(blogRequet.ImageString, string.Empty);
        blogRequet.Image = Convert.FromBase64String(image);

        return blogRequet.Image;
    }
    #endregion[Privados]
}
