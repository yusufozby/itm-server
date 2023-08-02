
namespace ITM_Server.Core.Domain;

public class Employee
{
    public int Id { get; set; }
    public string? NameSurname { get; set; }
    public string? IdentityNo { get; set; }
    public string? RecordNo { get; set; }
    public bool isWork { get; set; }
    public string RFIDCardNo { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public int DepartmentId { get; set; }
    public int JobId { get; set; }
    public int TypeId { get; set; }
    public List<LineTotalQuality> LineTotalQualities { get; set; }


}