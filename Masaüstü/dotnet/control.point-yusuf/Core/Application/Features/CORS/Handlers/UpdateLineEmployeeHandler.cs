using ITM_Server.Core.Application.Features.CORS.Queries;
using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class UpdateLineEmployeeHandler : IRequestHandler<UpdateLineEmployeeQuery>
{
    private readonly IRepository<LineEmployee> repository;

    public UpdateLineEmployeeHandler(IRepository<LineEmployee> repository)
    {
        this.repository = repository;
    }

    public async Task<Unit> Handle(UpdateLineEmployeeQuery request,CancellationToken cancellationToken)
    {
        var updatedLineEmployee = await repository.GetByFilterAsync(x => x.EmployeeId == request.employeeId);
        if (updatedLineEmployee == null)
        {
            await repository.CreateAsync(new LineEmployee()
            {
                EmployeeId = request.employeeId,
                LineId = request.lineId
            });
        }
      
        
        return Unit.Value;
    }  
}