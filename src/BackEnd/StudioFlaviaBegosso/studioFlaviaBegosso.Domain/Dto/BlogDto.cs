namespace studioFlaviaBegosso.Domain.Dto;
public class BlogDto
{
    public Guid? Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public byte[]? Image { get; set; }
    public string? ImageString { get; set; }
}
