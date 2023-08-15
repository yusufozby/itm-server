using ITM_Server.Core.Application.Features.CORS.Handlers;
using ITM_Server.Core.Application.Features.CORS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITM_Server.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LineEmployeeController : ControllerBase
{
    private readonly IMediator _mediator;
    public LineEmployeeController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> List()
    {
        var data = await this._mediator.Send(new GetAllLineEmployeeQuery());
        return Ok(data);
    }

    [HttpPost]
    public async Task<IActionResult> Update(UpdateLineEmployeeQuery request)
    {
        await this._mediator.Send(request);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var result = await this._mediator.Send(new DeleteLineEmployeeQuery(id));
        return result == null ? NotFound() : Ok(result);
    }

}