namespace ITM_Server.Core.Domain;

public class Order
{
    public int Id { get; set; }
    public int StyleId { get; set; }
    public DateTime DeadLineDate { get; set; }
    public bool IsArchived { get; set; }
    public String OrderNo { get; set; }
    public String Description { get; set; }
    public List<OrderPlan> OrderPlans { get; set; }
    public int LineId { get; set; }

    
}