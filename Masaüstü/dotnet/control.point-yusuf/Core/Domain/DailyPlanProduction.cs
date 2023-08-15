namespace ITM_Server.Core.Domain;

public class DailyPlanProduction
{
    public int Id { get; set; }
    public int YearlyProductionPlanId { get; set; }
    public DateTime Prod_Date { get; set; } 
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public int WeekNumber { get; set; }
    public bool isOff { get; set; }
    public int OverTime { get; set; }
}