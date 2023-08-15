namespace ITM_Server.Core.Domain;

public class Operation
{
  public int Id { get; set; }
  public string Name { get; set; }
  public string Code { get; set; }
  public int TypeID { get; set; }
  public string ReferansCode { get; set; }
  public int MachineId { get; set; }
  public int GroupId { get; set; }
  public int DepartmentId { get; set; }
  public int ApparatID { get; set; }
  public decimal TimeMinute { get; set; }
  public int TimeSecond { get; set; }
  public decimal Tolerance { get; set; }
  public string Description { get; set; }
  public string? Image { get; set; }

 public  List<OperationActivation>? OperationActivations { get; set; }


  
  
}