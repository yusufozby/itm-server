using ITM_Server.Core.Application.Features.CORS.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
namespace ITM_Server.Controllers;

[Route("api/{controller}")]
[ApiController]
public class AuthController : ControllerBase


{
   private readonly IMediator mediator;

    public AuthController(IMediator mediator)
    {
        this.mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Login(CheckUserQueryRequest request)
    {
        var dto = await this.mediator.Send(request);
        if (dto.isExist)
        {
            return Created("",dto);

        }
        else
        {
            return BadRequest("Kullanıcı adı veya şifre yanlış");
        }
    }


}