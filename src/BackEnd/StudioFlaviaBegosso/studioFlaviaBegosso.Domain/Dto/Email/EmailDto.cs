namespace studioFlaviaBegosso.Domain.Dto.Email;

public class EmailDto
{
    public Guid? Id { get; set; }
    public string? NameClient { get; set; }
    public string? PhoneClient { get; set; }
    public string? DescriptionClient { get; set; }
    public DateTime? DateSendUser { get; set; }
}
