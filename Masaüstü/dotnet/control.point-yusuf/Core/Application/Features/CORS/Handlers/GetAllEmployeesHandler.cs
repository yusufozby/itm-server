using AutoMapper;
using ITM_Server.Core.Application.Features.CORS.Queries;
using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;


public class GetAllEmployeesHandler : IRequestHandler<GetAllEmployeesQuery,List<Employee>>
{
    private readonly IRepository<Employee> repository; 
    private readonly IMapper _mapper;
 

    public GetAllEmployeesHandler(IRepository<Employee> repository,IMapper mapper)
    {
        this.repository = repository;
        this._mapper = mapper;
    }
    public async Task<List<Employee>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
    {
        var data = await this.repository.GetAllAsync();
        return this._mapper.Map<List<Employee>>(data);
    }
}
