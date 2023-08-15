using ITM_Server.Core.Application.Features.CORS.Handlers;
using ITM_Server.Core.Application.Features.CORS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITM_Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LineMovementController : ControllerBase
{
    private readonly IMediator mediator;

    public LineMovementController(IMediator mediator)
    {
        this.mediator = mediator;
    }
    [HttpPost]
    public async Task<IActionResult> Post(CreateLineMovementQuery request)
    {
      var result =   await this.mediator.Send(request);
        return Ok(result);
    }
    [HttpGet]
    public async Task<IActionResult> List()
    {
        var data = await this.mediator.Send(new GetAllLineMovementsQuery());
        return  Ok(data);
    }
    
}