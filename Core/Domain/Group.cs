namespace ITM_Server.Core.Domain;

public class Group
{
    public int Id { get; set; }
    public string GroupName { get; set; }
    public string GroupDescription { get; set; }
    public int GroupCodeId { get; set; }
    public GroupCode? GroupCode;
  
    public List<LineTotalQuality>? LineTotalQualities;


}