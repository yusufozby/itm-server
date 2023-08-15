using AutoMapper;
using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class GetAllLineEmployeesHandler : IRequestHandler<GetAllLineEmployeeQuery,List<LineEmployee>>
{
    private readonly IRepository<LineEmployee> _repository;
    private readonly  IMapper _mapper;
  

    public GetAllLineEmployeesHandler(IRepository<LineEmployee> repository,IMapper mapper)
    {
        this._repository = repository;
        this._mapper = mapper;
    } 

    public async Task<List<LineEmployee>> Handle(GetAllLineEmployeeQuery request, CancellationToken cancellationToken)
    {
        var data = await this._repository.GetAllAsync();
        return this._mapper.Map<List<LineEmployee>>(data);
    }
}