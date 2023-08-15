using ITM_Server.Core.Application.Dto;
using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Queries;

public class GetStyleVaryantQuery : IRequest<StyleVaryantListDto>
{
    public int styleId { get; set; }
    public int varyantId { get; set; }
}