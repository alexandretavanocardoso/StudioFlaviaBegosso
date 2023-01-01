using AutoMapper;
using studioFlaviaBegosso.Domain.Dto.Email;
using studioFlaviaBegosso.Domain.Interface.Repository.Email;
using studioFlaviaBegosso.Domain.Interface.Service.Email;
using studioFlaviaBegosso.Domain.Model;

namespace studioFlaviaBegosso.Business.Services.Email
{
    public class EmailService : IEmailService
    {
        private readonly IEmailRepository _emailRepository;
        private readonly IMapper _mapper;

        public EmailService(IEmailRepository emailRepository, IMapper mapper)
        {
            _emailRepository = emailRepository;
            _mapper = mapper;
        }

        public async Task<List<EmailDto>> GetAllEmailAsync()
        {
            List<EmailModel> blogModel = await _emailRepository.GetAllEmail();
            return _mapper.Map<List<EmailDto>>(blogModel);
        }

        public async Task<EmailDto> GetEmailAsync(Guid id)
        {
            EmailModel blogModel = await _emailRepository.GetEmail(id);
            return _mapper.Map<EmailDto>(blogModel);
        }

        public async Task<bool> SendEmailAsync(EmailDto blogRequet)
        {
            EmailModel model = _mapper.Map<EmailModel>(blogRequet);
            return await _emailRepository.InsertEmail(model);
        }

        public async Task<bool> DeleteEmailAsync(Guid id)
            => await _emailRepository.DeleteEmail(id);
    }
}
