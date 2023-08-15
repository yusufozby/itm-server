namespace ITM_Server.Core.Domain;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int GroupCodeId { get; set; }
    public GroupCode? GroupCode;
  
    public List<LineTotalQuality>? LineTotalQualities;


}