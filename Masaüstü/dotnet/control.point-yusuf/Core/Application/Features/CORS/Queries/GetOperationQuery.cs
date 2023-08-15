using ITM_Server.Core.Application.Dto;
using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Queries;

public class GetOperationQuery : IRequest<Operation>
{
    public int Id { get; set; }

    public GetOperationQuery(int operationid)
    {
        Id = operationid;
    }
}