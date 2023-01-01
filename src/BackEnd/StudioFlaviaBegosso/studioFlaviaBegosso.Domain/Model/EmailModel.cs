using StudioFlaviaBegosso.Domain.Model;

namespace studioFlaviaBegosso.Domain.Model;
public class EmailModel : EntityModel
{
    public string? NameClient { get; set; }
    public string? SubjectClient { get; set; }
    public string? PhoneClient { get; set; }
    public string? DescriptionClient { get; set; }
    public DateTime? DateSendUser { get; set; } = DateTime.Now;
}
