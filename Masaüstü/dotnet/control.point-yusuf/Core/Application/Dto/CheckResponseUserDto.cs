namespace ITM_Server.Core.Application.Dto;

public class CheckResponseUserDto
{
    public int Id { get; set; }
    public string? Username { get; set; }
  
    public bool isExist { get; set; }
    
    public string nameSurname { get; set; }
}