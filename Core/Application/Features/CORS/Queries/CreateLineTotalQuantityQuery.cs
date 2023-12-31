using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Queries;

public class CreateLineTotalQuantityQuery : IRequest
{
    public int EmployeeId { get; set; }
    public int GroupId { get; set; }
    public int StyleVaryantId { get; set; }
}