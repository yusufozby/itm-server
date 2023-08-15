using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Queries;

public class CreateLineEmployeeQuery : IRequest
{
    public int employeeId { get; set; }
    public int LineId { get; set; }
}