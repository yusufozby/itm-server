namespace ITM_Server.Core.Domain;

public class Line
{
    public int Id { get; set; }
    public decimal TargetProductivity { get; set; }
    public int LCDNo { get; set; }
    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}