using AutoMapper;
using ITM_Server.Core.Application.Features.CORS.Queries;
using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class GetAllLineMovementsHandler : IRequestHandler<GetAllLineMovementsQuery,List<LineMovement>>
{private readonly  IRepository<LineMovement> _repository;
    private readonly IMapper _mapper;
  

    public GetAllLineMovementsHandler(IRepository<LineMovement> repository,IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    } 
  

    public async Task<List<LineMovement>> Handle(GetAllLineMovementsQuery request, CancellationToken cancellationToken)
    {
        var data = await this._repository.GetAllAsync();
        return this._mapper.Map<List<LineMovement>>(data);
    }
}
    
