using StudioFlaviaBegosso.Domain.Model;

namespace studioFlaviaBegosso.Domain.Model.Adm;
public class ScheduleClientModel : EntityModel
{
    public ClientModel? Client { get; set; }
    public Guid ClientId { get; set; }

    public ProcedureModel? Procedure { get; set; }
    public Guid ProcedureId { get; set; }

    public MaintenanceModel? Maintenance { get; set; }
    public Guid MaintenanceId { get; set; }

    public MaintenanceChooseModel? MaintenanceChoose { get; set; }
    public Guid MaintenanceChooseId { get; set; }

    public DateTime DateFullAplication { get; set; }
    public DateTime DateMaintenance { get; set; }
    public bool SendNotification { get; set; }
}
