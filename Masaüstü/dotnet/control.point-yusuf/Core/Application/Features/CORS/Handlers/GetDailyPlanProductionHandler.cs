using AutoMapper;
using ITM_Server.Core.Application.Features.CORS.Queries;
using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class GetDailyPlanProductionHandler : IRequestHandler<GetDailyPlanProductionQuery,List<DailyPlanProduction>>
{
    private readonly IMapper _mapper;
    private readonly IRepository<DailyPlanProduction> repository;
    public GetDailyPlanProductionHandler(IMapper mapper, IRepository<DailyPlanProduction> repository)
    {
        this._mapper = mapper;
        this.repository = repository;
    }
    public async Task<List<DailyPlanProduction>> Handle(GetDailyPlanProductionQuery request, CancellationToken cancellationToken)
    {
        var data = await this.repository.GetAllAsync();
        return this._mapper.Map<List<DailyPlanProduction>>(data);
    }
}