namespace StudioFlaviaBegosso.Domain.Model;

public class EntityModel
{
    public EntityModel()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? DateCreation { get; set; }
    public string? EditBy { get; set; }
    public DateTime? DateUpdate { get; set; }
}
