namespace ITM_Server.Core.Domain;

public class GroupCode
{
    public int Id { get; set; }
    public string GroupCodeName { get; set; }
    public string GroupCodeDescription { get; set; }
    
    public List<Group>? Groups;
    

   

}