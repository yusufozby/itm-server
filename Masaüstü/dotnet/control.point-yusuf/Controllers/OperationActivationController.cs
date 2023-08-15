using ITM_Server.Core.Application.Features.CORS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ITM_Server.Controllers;
[Route("api/activation")]
[ApiController]
public class OperationActivationController : ControllerBase
{
    private readonly IMediator mediator;

    public OperationActivationController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Login(GetOperationActivationQuery request)
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

