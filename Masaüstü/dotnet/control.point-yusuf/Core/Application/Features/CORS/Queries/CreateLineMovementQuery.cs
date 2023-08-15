using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class CreateLineMovementQuery : IRequest
{

    public int EmployeeId { get; set; }
    public int LineId { get; set; }
  
    public string startTime { get; set; }
    

        
}


