namespace studioFlaviaBegosso.Domain.Dto.Adm;
public class ScheduleClientHistoryDto
{
    public ClientDto? Client { get; set; }
    public ProcedureDto? Procedure { get; set; }
    public MaintenanceDto? Maintenance { get; set; }
    public MaintenanceChooseDto? MaintenanceChoose { get; set; }
    public Guid? Id { get; set; }
    public DateTime DateFullAplication { get; set; }
    public DateTime DateMaintenance { get; set; }
    public bool SendNotification { get; set; }
    public bool IsInsert { get; set; }
    public bool IsUpdate { get; set; }
}
