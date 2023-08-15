using ITM_Server.Core.Application.Features.CORS.Queries;
using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class CreateLineTotalHandler : IRequestHandler<CreateLineTotalQuantityQuery>
{
    private readonly IRepository<LineTotalQuality> repository;

    public CreateLineTotalHandler(IRepository<LineTotalQuality> repository)
    {
        this.repository = repository;
    }

    public async Task<Unit> Handle(CreateLineTotalQuantityQuery request,CancellationToken cancellationToken)
    {
        await this.repository.CreateAsync(new LineTotalQuality()
        {
            LineId = request.lineId,
           EmployeeId = request.EmployeeId,
           Style_VaryantId = request.StyleVaryantId,
           GroupId = request.GroupId,
           Quantity = request.Quantity
           


        });
        return Unit.Value;
    }  
}