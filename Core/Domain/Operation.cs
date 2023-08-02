namespace ITM_Server.Core.Domain;

public class Operation
{
  public int Id { get; set; }
  public string Name { get; set; }
  public int Code { get; set; }
  public int TypeID { get; set; }
  public string ReferansCode { get; set; }
  public int MachineId { get; set; }
  public int GroupId { get; set; }
  public int DepartmentId { get; set; }
  public int AparatID { get; set; }
  public int OperationTimeSpeed { get; set; }
  public int OperationTime { get; set; }
  public decimal Tolerance { get; set; }
  public string Description { get; set; }
  public string OperationImage { get; set; }

 public  List<OperationActivation>? OperationActivations { get; set; }


  
  
}