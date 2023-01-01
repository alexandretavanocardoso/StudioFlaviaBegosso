namespace StudioFlaviaBegosso.Domain.Model;

public class BlogModel : EntityModel
{
    public string? Name { get; set; }
    public string? Description { get; set; }
    public byte[]? Image { get; set; }
    public DateTime? DatePublication { get; set; } = DateTime.Now;
}
