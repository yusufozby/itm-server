namespace ITM_Server.Core.Domain;

public class LineTotalQuality
{
    public int Id { get; set; }
    public int LineId { get; set; }
    public StyleVaryant StyleVaryant { get; set; }
    public int GroupId { get; set; }

    public DateTime createTime { get; set; } = DateTime.Now;
    public int styleVaryantId { get; set; }
    
    public Group Group { get; set; }
    public Employee Employee { get; set; }
    public int EmployeeId { get; set; }



}