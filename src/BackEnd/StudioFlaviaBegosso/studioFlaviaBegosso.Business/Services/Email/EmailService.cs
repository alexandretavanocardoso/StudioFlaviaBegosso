using Aspose.Email;
using Aspose.Email.Clients;
using Aspose.Email.Clients.Smtp;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using studioFlaviaBegosso.Domain.Dto.Email;
using studioFlaviaBegosso.Domain.Interface.Repository.Email;
using studioFlaviaBegosso.Domain.Interface.Service.Email;
using studioFlaviaBegosso.Domain.Model;

namespace studioFlaviaBegosso.Business.Services.Email
{
    public class EmailService : IEmailService
    {
        private readonly IEmailRepository _emailRepository;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public EmailService(IEmailRepository emailRepository, IConfiguration configuration, IMapper mapper)
        {
            _emailRepository = emailRepository;
            _configuration = configuration;
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
            bool send = SendAsync();
            if (!send) return false;

            return await InsertEmailAsync(blogRequet);
        }

        public async Task<bool> DeleteEmailAsync(Guid id)
        {
            return await _emailRepository.DeleteEmail(id);
        }

        #region[Privados]
        public async Task<bool> InsertEmailAsync(EmailDto blogRequet)
        {
            EmailModel model = _mapper.Map<EmailModel>(blogRequet);
            return await _emailRepository.InsertEmail(model);
        }

        private bool SendAsync()
        {
            MailMessage msg = GetEmailMailMessage();
            SmtpClient client = GetEmailSmtpClient();

            client.SendAsync(msg);
            msg.Dispose();

            return true;
        }

        private MailMessage GetEmailMailMessage()
        {
            MailMessage msg = new MailMessage();
            msg.Subject = "Vim do site!";
            msg.Body = GetBody();

            return msg;
        }

        private string GetBody()
        {
            return @"";
        }

        private SmtpClient GetEmailSmtpClient()
        {
            SmtpClient client = new SmtpClient();

            // Especifique seu host de correspondência, nome de usuário, senha, número da porta e opção de segurança
            client.Host = _configuration["PropEmail:Host"];
            client.Username = _configuration["PropEmail:Username"];
            client.Password = _configuration["PropEmail:Password"];
            client.Port = 587;
            client.SecurityOptions = SecurityOptions.SSLExplicit;

            return client;
        }
        #endregion[Privados]
    }
}
