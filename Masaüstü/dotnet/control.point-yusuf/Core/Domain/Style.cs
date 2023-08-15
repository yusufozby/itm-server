namespace ITM_Server.Core.Domain;

public class Style
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string ReferanceNo { get; set; }
    public int CustomerID { get; set; }
    public int SeasonGroupId { get; set; }
    public int CatalogGroupId { get; set; }
    public int SetGroupId { get; set; }
    public int CostingPeriodId { get; set; }
    public int StyleRouteId { get; set; }
    public bool isArchived { get; set; }
    public string? Image { get; set; }

    public List<StyleVaryant> StyleVaryants { get; set; }
   public List<OperationActivation> OperationActivations { get; set; }

   
}