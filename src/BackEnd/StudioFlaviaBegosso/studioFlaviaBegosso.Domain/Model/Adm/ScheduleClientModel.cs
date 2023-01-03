using StudioFlaviaBegosso.Domain.Model;

namespace studioFlaviaBegosso.Domain.Model.Adm;
public class ScheduleClientModel : EntityModel
{
    /* 
        FKS
        
        - ClientModel
        - ProcedureModel
        - MaintenanceModel
        - MaintenanceChooseModel
     */

    public DateTime DateFullAplication { get; set; }
    public DateTime DateMaintenance { get; set; }
    public bool SendNotification { get; set; }
}
