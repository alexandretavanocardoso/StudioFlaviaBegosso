using StudioFlaviaBegosso.Domain.Model;

namespace studioFlaviaBegosso.Domain.Model.Adm;
public class ScheduleClientHistoryModel : EntityModel
{
    public DateTime DateFullAplication { get; set; }
    public DateTime DateMaintenance { get; set; }
    public bool SendNotification { get; set; }
    public bool IsInsert { get; set; }
    public bool IsUpdate { get; set; } = false;
}
