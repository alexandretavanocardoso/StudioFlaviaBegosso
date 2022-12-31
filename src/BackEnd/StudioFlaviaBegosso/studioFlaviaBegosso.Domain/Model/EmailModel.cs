using StudioFlaviaBegosso.Domain.Model;

namespace studioFlaviaBegosso.Domain.Model;
public class EmailModel : EntityModel
{
    public int NameClient { get; set; }
    public int PhoneClient { get; set; }
    public int DescriptionClient { get; set; }
}
