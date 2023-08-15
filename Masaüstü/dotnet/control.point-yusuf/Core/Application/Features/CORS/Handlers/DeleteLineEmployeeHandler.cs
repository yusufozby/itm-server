using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class DeleteLineEmployeeHandler : IRequestHandler<DeleteLineEmployeeQuery>

{

    private readonly IRepository<LineEmployee> repository;

    public DeleteLineEmployeeHandler(IRepository<LineEmployee> repository)
    {
        this.repository = repository;
    }
    public async Task<Unit> Handle(DeleteLineEmployeeQuery request, CancellationToken cancellationToken)
    {
        var deletedEntity = await this.repository.GetByIdAsync(request.Id);
        if (deletedEntity != null)
        {
            await this.repository.RemoveAsync(deletedEntity);          
        }
  
        return Unit.Value;
    }
}