using AutoMapper;
using studioFlaviaBegosso.Domain.Dto;
using studioFlaviaBegosso.Domain.Dto.Adm;
using studioFlaviaBegosso.Domain.Dto.Email;
using studioFlaviaBegosso.Domain.Model;
using studioFlaviaBegosso.Domain.Model.Adm;
using StudioFlaviaBegosso.Domain.Model;

namespace StudioFlaviaBegosso.Configuration
{
    public class AutoMapperConfiguration : Profile
    {
        public AutoMapperConfiguration()
        {
            CreateMap<BlogModel, BlogDto>()
                .ReverseMap();
            CreateMap<QuestionFrequentModel, QuestionFrequentDto>()
                .ReverseMap();
            CreateMap<WorkModel, WorkDto>()
                .ReverseMap();
            CreateMap<GalleryModel, GalleryDto>()
                .ReverseMap();
            CreateMap<EmailModel, EmailDto>()
                .ReverseMap();
            CreateMap<ClientModel, ClientDto>()
                .ReverseMap();
            CreateMap<MaintenanceModel, MaintenanceDto>()
                .ReverseMap();
            CreateMap<ProcedureModel, ProcedureDto>()
                .ReverseMap();
            CreateMap<MaintenanceChooseModel, MaintenanceChooseDto>()
                .ReverseMap();
            CreateMap<ScheduleClientModel, ScheduleClientDto>()
               .ReverseMap();
            CreateMap<ScheduleClientHistoryModel, ScheduleClientHistoryDto>()
               .ReverseMap();
        }
    }
}
