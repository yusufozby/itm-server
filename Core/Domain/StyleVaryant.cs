namespace ITM_Server.Core.Domain;

public class StyleVaryant
{
    public int Id { get; set; }
    public int StyleId { get; set; }
    public int VaryantId { get; set; }
    public Varyant Varyant { get; set; }
    public List<LineTotalQuality> LineTotalQualities { get; set; }
    public Style Style;


}