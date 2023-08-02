
using AutoMapper;
using ITM_Server.Core.Application.Dto;
using ITM_Server.Core.Application.Features.CORS.Queries;
using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class GetStyleHandler : IRequestHandler<GetStyleQuery, StyleDto>
{
    public readonly IRepository<Style> repository;
    public readonly IMapper Mapper;

    public GetStyleHandler(IRepository<Style> repository,IMapper Mapper)
    {
        this.repository = repository;
        this.Mapper = Mapper;
    }

    public async Task<StyleDto> Handle(GetStyleQuery request, CancellationToken cancellationToken)
    {
        var dto = new StyleDto();
        var style = await this.repository.GetByFilterAsync(x => x.Id == request.Id);
        if (style != null)
        {
            dto.Id = style.Id;
            dto.Image = style.Image;
            dto.isExist = true;
            dto.Name = style.Name;
        }
        else
        {
            dto.isExist = false;
        }

        return dto;
    }
}