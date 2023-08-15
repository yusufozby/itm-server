using ITM_Server.Core.Application.Dto;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Queries;

public class GetStyleQuery : IRequest<StyleDto>
{
    public int Id { get; set; }
    
    
}