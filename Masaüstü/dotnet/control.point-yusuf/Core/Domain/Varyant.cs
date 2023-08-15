namespace ITM_Server.Core.Domain;

public class Varyant
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
  
  
    public List<StyleVaryant> StyleVaryants { get; set; }
     
 

}