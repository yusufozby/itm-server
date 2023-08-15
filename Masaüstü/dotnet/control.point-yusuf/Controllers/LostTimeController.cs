using ITM_Server.Core.Application.Features.CORS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITM_Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LostTimeController : ControllerBase
{
    private readonly IMediator mediator;

    public LostTimeController(IMediator mediator)
    {
        this.mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> List()
    {
        var result =await   this.mediator.Send(new GetAllLostTimesQuery());
        return Ok(result);
    }
    
}