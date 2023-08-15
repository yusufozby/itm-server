using AutoMapper;
using ITM_Server.Core.Application.Dto;
using ITM_Server.Core.Application.Features.CORS.Queries;
using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Core.Domain;
using MediatR;

using Operation = ITM_Server.Core.Domain.Operation;


namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class GetOperationHandler : IRequestHandler<GetOperationQuery, Operation>
{
    private readonly IMapper mapper;
    private readonly IRepository<Operation> repository;

    public GetOperationHandler(IRepository<Operation> repository,IMapper mapper)
    {
        this.repository = repository;
        this.mapper = mapper;
    }

    public async Task<Operation> Handle(GetOperationQuery request, CancellationToken token)

    {
        var data = await this.repository.GetByFilterAsync(x => x.Id == request.Id);
        return this.mapper.Map<Operation>(data);
    }
}