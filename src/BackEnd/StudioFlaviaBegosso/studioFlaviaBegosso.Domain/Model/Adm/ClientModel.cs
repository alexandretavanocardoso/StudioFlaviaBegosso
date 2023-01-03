using StudioFlaviaBegosso.Domain.Model;

namespace studioFlaviaBegosso.Domain.Model.Adm;

public class ClientModel : EntityModel
{
    public string? NameFull { get; set; }
    public string? City { get; set; }
    public int? Age { get; set; }
}
