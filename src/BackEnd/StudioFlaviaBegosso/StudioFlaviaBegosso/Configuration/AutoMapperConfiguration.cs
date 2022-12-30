using AutoMapper;
using studioFlaviaBegosso.Domain.Dto;
using StudioFlaviaBegosso.Domain.Model;

namespace StudioFlaviaBegosso.Configuration
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<BlogModel, BlogDto>().ReverseMap();
            CreateMap<QuestionFrequentModel, QuestionFrequentDto>().ReverseMap();
            CreateMap<WorkModel, WorkDto>().ReverseMap();
            CreateMap<GalleryModel, GalleryDto>().ReverseMap();
        }
    }
}
