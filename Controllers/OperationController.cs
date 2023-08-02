using ITM_Server.Core.Application.Features.CORS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITM_Server.Controllers;

[Route("api/operation")]
[ApiController]
public class OperationController : ControllerBase
{
    private readonly IMediator mediator;

    public OperationController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpGet("{Id}")]
    
 
    public async Task<IActionResult> Get(int Id)
    {
        var result = await this.mediator.Send(new GetOperationQuery(Id));
        return Ok(result);
    }


}