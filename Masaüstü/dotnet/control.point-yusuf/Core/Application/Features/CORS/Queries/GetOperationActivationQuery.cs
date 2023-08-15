using ITM_Server.Core.Application.Dto;
using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Queries;

public class GetOperationActivationQuery :  IRequest<ActivationListDto>

{
    public int activationCode { get; set; }
}