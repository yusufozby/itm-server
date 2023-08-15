using ITM_Server.Core.Application.Features.CORS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITM_Server.Controllers;

[Route("api/lines")]
[ApiController]
public class LineController : ControllerBase
{
    private readonly IMediator mediator;

    public LineController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> List()
    {
        var result = await this.mediator.Send(new GetAllLinesQuery());
        return Ok(result);
    }
}