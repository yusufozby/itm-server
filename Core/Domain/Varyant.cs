namespace ITM_Server.Core.Domain;

public class Varyant
{
    public int Id { get; set; }
    public string VaryantName { get; set; }
    public string VaryantDescription { get; set; }
    public string VaryantCode { get; set; }
  
    public List<StyleVaryant> StyleVaryants { get; set; }
     
 

}