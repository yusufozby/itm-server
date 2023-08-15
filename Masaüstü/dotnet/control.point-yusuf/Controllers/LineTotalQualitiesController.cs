using ITM_Server.Core.Application.Features.CORS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITM_Server.Controllers;
[Route("api/linequantites")]
[ApiController]
public class LineTotalQualitiesController : ControllerBase
{
    private readonly IMediator mediator;

    public LineTotalQualitiesController(IMediator mediator)
    {
        this.mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> List()
    {
        var result =await   this.mediator.Send(new GetAllLineTotalQualityQuery());
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Post(CreateLineTotalQuantityQuery request)
    {
        await this.mediator.Send(request);
        return Ok(request);
    }
}