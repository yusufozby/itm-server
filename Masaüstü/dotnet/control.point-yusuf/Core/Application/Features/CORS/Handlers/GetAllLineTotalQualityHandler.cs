using AutoMapper;
using ITM_Server.Core.Application.Dto;
using ITM_Server.Core.Application.Features.CORS.Queries;
using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class GetAllLinesQualityHandler : IRequestHandler<GetAllLineTotalQualityQuery,List<LineTotalQuality>>
{
    private readonly IRepository<LineTotalQuality> _repository;
    private readonly IMapper _mapper;
  

    public GetAllLinesQualityHandler(IRepository<LineTotalQuality> repository,IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    } public async Task<List<LineTotalQuality>> Handle(GetAllLineTotalQualityQuery request, CancellationToken cancellationToken)
    {
        var data = await this._repository.GetAllAsync();
        return this._mapper.Map<List<LineTotalQuality>>(data);
    }
}