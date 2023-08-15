using ITM_Server.Core.Application.Features.CORS.Queries;
using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class CreateLineEmployeeHandler : IRequestHandler<CreateLineEmployeeQuery>
{
    private readonly IRepository<LineEmployee> repository;

    public CreateLineEmployeeHandler(IRepository<LineEmployee> repository)
    {
        this.repository = repository;
    }

    public async Task<Unit> Handle(CreateLineEmployeeQuery request, CancellationToken cancellationToken)
    {
        await this.repository.CreateAsync(new LineEmployee()
        {
            LineId = request.LineId,
            EmployeeId = request.employeeId,




        });
        return Unit.Value;
    }
}