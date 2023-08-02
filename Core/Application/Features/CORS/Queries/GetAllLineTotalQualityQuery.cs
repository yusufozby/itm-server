using ITM_Server.Core.Application.Dto;
using ITM_Server.Core.Domain;
using MediatR;
using StyleVaryant = ITM_Server.Core.Domain.StyleVaryant;

namespace ITM_Server.Core.Application.Features.CORS.Queries;

public class GetAllLineTotalQualityQuery : IRequest<List<LineTotalQuality>>
{
 
}