using StudioFlaviaBegosso.Domain.Model;

namespace studioFlaviaBegosso.Domain.Model.Adm;
public class MaintenanceChooseModel : EntityModel
{
    public string? Name { get; set; }

    public ScheduleClientModel? ScheduleClient { get; set; }
}
