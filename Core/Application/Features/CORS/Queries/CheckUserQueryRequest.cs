using ITM_Server.Core.Application.Dto;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Queries;

public class CheckUserQueryRequest : IRequest<CheckResponseUserDto>
{
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
}