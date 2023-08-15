using ITM_Server.Core.Application.Features.CORS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITM_Server.Controllers;
[Route("api/stylevaryants")]
[ApiController]
public class StyleVaryantController : ControllerBase
{
    private readonly IMediator mediator;

    public StyleVaryantController(IMediator mediator)
    {
        this.mediator = mediator;
    }
    [HttpGet]
    public async Task<IActionResult> List()
    {
        var result =await   this.mediator.Send(new GetAllStyleVaryantsQuery());
        return Ok(result);
    }
    [HttpPost]
    public async Task<IActionResult> Login(GetStyleVaryantQuery request)
    {
        var dto = await this.mediator.Send(request);
        if (dto.isExist)
        {
            return Created("",dto);

        }
        else
        {
            return BadRequest();
        }
    }
}