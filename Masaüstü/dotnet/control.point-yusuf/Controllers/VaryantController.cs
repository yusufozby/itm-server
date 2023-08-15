using ITM_Server.Core.Application.Features.CORS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITM_Server.Controllers;
[Route("api/varyants")]
[ApiController]
public class VaryantController : ControllerBase
{
    private readonly IMediator mediator;

    public VaryantController(IMediator mediator)
    {
        this.mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> List()
    {
        var result =await   this.mediator.Send(new GetAllVaryantsQuery());
        return Ok(result);
    }
}