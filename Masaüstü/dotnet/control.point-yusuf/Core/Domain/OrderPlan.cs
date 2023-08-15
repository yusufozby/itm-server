namespace ITM_Server.Core.Domain;

public class OrderPlan
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int StyleId { get; set; }
    public int LineId { get; set; }
    public DateTime RealStartDate { get; set; }
    public DateTime RealEndDate { get; set; }
    public bool isArchived { get; set; }
    public int PlanQuantity { get; set; }
    public int RealQuantity { get; set; }
    public int OrderSequence { get; set; }
    public bool isLcd { get; set; }
    public int WorkerCount { get; set; }
    public Style Style { get; set; }
  


}