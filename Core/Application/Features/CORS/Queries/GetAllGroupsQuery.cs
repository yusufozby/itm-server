using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Queries;

public class GetAllGroupsQuery : IRequest<List<Group>>
{
    
}