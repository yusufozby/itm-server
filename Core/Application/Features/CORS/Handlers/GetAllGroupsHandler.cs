using AutoMapper;
using ITM_Server.Core.Application.Features.CORS.Queries;
using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class GetAllGroupsHandler : IRequestHandler<GetAllGroupsQuery,List<Group>>
{
    private readonly IRepository<Group> _repository;
    private readonly  IMapper _mapper;
  

    public GetAllGroupsHandler(IRepository<Group> repository,IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    } 

    public async Task<List<Group>> Handle(GetAllGroupsQuery request, CancellationToken cancellationToken)
    {
        var data = await this._repository.GetAllAsync();
        return this._mapper.Map<List<Group>>(data);
    }
}