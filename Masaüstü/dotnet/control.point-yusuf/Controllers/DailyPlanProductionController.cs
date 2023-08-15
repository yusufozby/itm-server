using ITM_Server.Core.Application.Features.CORS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITM_Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DailyPlanProductionController : ControllerBase
{
    private readonly IMediator mediator;

    public DailyPlanProductionController(IMediator mediator)
    {
        this.mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> List()
    {
        var data = await this.mediator.Send(new GetDailyPlanProductionQuery());
        return Ok(data);
    }
}