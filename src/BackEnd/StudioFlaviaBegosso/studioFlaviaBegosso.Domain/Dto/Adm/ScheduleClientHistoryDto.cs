namespace studioFlaviaBegosso.Domain.Dto.Adm;
public class ScheduleClientHistoryDto
{
    public DateTime DateFullAplication { get; set; }
    public DateTime DateMaintenance { get; set; }
    public bool SendNotification { get; set; }
    public bool IsInsert { get; set; }
    public bool IsUpdate { get; set; }
}
