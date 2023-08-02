namespace ITM_Server.Core.Domain;

public class OperationActivation
{
    public int Id { get; set; }
    public int LineId { get; set; }
    public int OperationId { get; set; }
    public int ActivationCode { get; set; }
    public Operation? Operation { get; set; }
    public int styleId { get; set; }
    public Style Style { get; set; }

    public OperationActivation()
    {
        Operation = new Operation();
        Style = new Style();
    }

   
}