using System.Runtime.InteropServices.JavaScript;
using AutoMapper;
using ITM_Server.Core.Application.Dto;
using ITM_Server.Core.Application.Features.CORS.Queries;
using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class
    GetOperationActivationHandler : IRequestHandler<GetOperationActivationQuery, ActivationListDto>
{
    private readonly IRepository<OperationActivation> repository;


    public GetOperationActivationHandler(IRepository<OperationActivation> repository)
    {

        this.repository = repository;
    }

    public async Task<ActivationListDto> Handle(GetOperationActivationQuery request, CancellationToken token)
    {
        var dto = new ActivationListDto();
        var activationCode = await this.repository.GetByFilterAsync(x => x.ActivationCode == request.activationCode);
        if (activationCode == null)
        {
            dto.isExist = false;
        }
        else
        {
            dto.isExist = true;
            dto.ActivationCode = request.activationCode;
  
            dto.styleId = activationCode.styleId;
            dto.operationId = activationCode.OperationId;

        }

        return dto;

    }
}