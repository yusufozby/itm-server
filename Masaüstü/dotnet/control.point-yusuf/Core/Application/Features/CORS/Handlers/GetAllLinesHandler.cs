using AutoMapper;
using ITM_Server.Core.Application.Features.CORS.Queries;
using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class GetAllLinesHandler : IRequestHandler<GetAllLinesQuery,List<Line>>
{
    private readonly  IRepository<Line> _repository;
    private readonly IMapper _mapper;
  

    public GetAllLinesHandler(IRepository<Line> repository,IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    } 
    public async Task<List<Line>> Handle(GetAllLinesQuery request, CancellationToken cancellationToken)
    {
        var data = await this._repository.GetAllAsync();
        return this._mapper.Map<List<Line>>(data);
    }
}