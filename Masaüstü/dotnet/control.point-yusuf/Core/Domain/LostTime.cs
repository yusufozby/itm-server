namespace ITM_Server.Core.Domain;

public class LostTime
{
    public int Id { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public int TypeId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}