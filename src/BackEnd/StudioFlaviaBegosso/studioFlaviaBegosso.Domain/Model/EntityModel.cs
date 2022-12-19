namespace StudioFlaviaBegosso.Domain.Model;

public class EntityModel
{
    public EntityModel()
    {
        Id = Guid.NewGuid();
    }

    public Guid Id { get; set; }
    public string? CreatedBy { get; set; } = "Flávia Alessandra Begosso";
    public DateTime? DateCreation { get; set; } = DateTime.Now;
    public string? EditBy { get; set; } = "Flávia Alessandra Begosso";
    public DateTime? DateUpdate { get; set; } = DateTime.Now;
}
