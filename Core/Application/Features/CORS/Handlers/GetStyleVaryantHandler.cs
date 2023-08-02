using AutoMapper;
using ITM_Server.Core.Application.Dto;
using ITM_Server.Core.Application.Features.CORS.Queries;
using ITM_Server.Core.Application.Interfaces;
using MediatR;
using StyleVaryant = ITM_Server.Core.Domain.StyleVaryant;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class GetStyleVaryantHandler : IRequestHandler<GetStyleVaryantQuery,StyleVaryantListDto>
{
    public readonly IRepository<StyleVaryant> repository;
    public readonly IMapper mapper;

    public GetStyleVaryantHandler(IRepository<StyleVaryant> repository,IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }

    public async Task<StyleVaryantListDto> Handle(GetStyleVaryantQuery request, CancellationToken cancellationToken)
    {
        var dto = new StyleVaryantListDto();
        var styleVaryant = await this.repository.GetByFilterAsync(x =>
            (x.StyleId== request.styleId)
        && (x.VaryantId == request.varyantId));
        if (styleVaryant == null)
        {
            dto.isExist = false;
        }
        else
        {
            dto.isExist = true;
            dto.styleId = request.styleId;
            dto.varyantId = request.styleId;
            dto.Id = styleVaryant.Id;
        }

        return dto;
    }
}