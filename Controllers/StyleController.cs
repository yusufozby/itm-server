using ITM_Server.Core.Application.Features.CORS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ITM_Server.Controllers;
[Route("api/style")]
[ApiController]

public class StyleController:ControllerBase
{
    private readonly IMediator mediator;

    public StyleController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Login(GetStyleQuery request)
    {
        var dto = await this.mediator.Send(request);
        if (dto.isExist)
        {
            return Created("", dto);

        }
        else
        {
            return BadRequest();
        }
    }
}