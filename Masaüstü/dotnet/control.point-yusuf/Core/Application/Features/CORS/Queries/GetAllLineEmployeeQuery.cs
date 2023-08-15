using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class GetAllLineEmployeeQuery : IRequest<List<LineEmployee>>
{
    
}