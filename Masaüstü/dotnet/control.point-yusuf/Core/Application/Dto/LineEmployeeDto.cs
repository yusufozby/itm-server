namespace ITM_Server.Core.Application.Dto;

public class LineEmployeeDto
{
    public int Id { get; set; }
    public int lineId { get; set; }
    public int employeeId { get; set; }
    public bool isExist { get; set; }
}