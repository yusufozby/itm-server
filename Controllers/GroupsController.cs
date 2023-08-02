using ITM_Server.Core.Application.Features.CORS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITM_Server.Controllers;
[Route("api/groups")]
[ApiController]
public class GroupsController : ControllerBase
{
    private readonly IMediator _mediator;
    public GroupsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> List()
    {
        var data = await this._mediator.Send(new GetAllGroupsQuery());
        return Ok(data);
    }
}