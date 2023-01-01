namespace StudioFlaviaBegosso.Domain.Model;

public class WorkModel : EntityModel
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public byte[]? Image { get; set; }
}
