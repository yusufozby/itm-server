using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Queries;

public class UpdateLineEmployeeQuery : IRequest
{

    public int lineId { get; set; }
    public int employeeId { get; set; }
}