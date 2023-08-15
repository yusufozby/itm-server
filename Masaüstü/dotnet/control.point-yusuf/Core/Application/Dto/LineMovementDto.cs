namespace ITM_Server.Core.Application.Dto;

public class LineMovementDto
{   public int DailyProductionPlanId { get; set; }
    public int EmployeeId { get; set; }
    public int lineId { get; set; } 
    public TimeSpan? EmployeeStartTime { get; set; }
    public TimeSpan? EmployeeEndTime { get; set; }
    public int lostTimeId { get; set; }
    public bool isExist { get; set; }

}