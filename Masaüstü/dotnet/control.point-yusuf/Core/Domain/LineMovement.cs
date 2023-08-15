namespace ITM_Server.Core.Domain;

public class LineMovement
{
    
    public int Id { get; set; }
    public int DailyProductionPlanId { get; set; }
    public int EmployeeId { get; set; }
    public int lineId { get; set; } 
    public TimeSpan? EmployeeStartTime { get; set; }
    public TimeSpan? EmployeeEndTime { get; set; }
    public int lostTimeId { get; set; }
    
}