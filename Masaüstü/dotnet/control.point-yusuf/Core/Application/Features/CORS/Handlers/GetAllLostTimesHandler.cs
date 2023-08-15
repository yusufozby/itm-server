using AutoMapper;
using ITM_Server.Core.Application.Features.CORS.Queries;
using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class GetAllLostTimesHandler : IRequestHandler<GetAllLostTimesQuery, List<LostTime>>
{
    private readonly IRepository<LostTime> _repository;
    private readonly IMapper _mapper;


    public GetAllLostTimesHandler(IRepository<LostTime> repository, IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    }

 

    public async Task<List<LostTime>> Handle(GetAllLostTimesQuery request, CancellationToken cancellationToken)
    {
        var data = await this._repository.GetAllAsync();
        return this._mapper.Map<List<LostTime>>(data);
    }
}