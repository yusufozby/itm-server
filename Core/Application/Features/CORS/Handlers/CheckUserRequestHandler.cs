using ITM_Server.Core.Application.Dto;
using ITM_Server.Core.Application.Features.CORS.Queries;
using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class CheckUserRequestHandler : IRequestHandler<CheckUserQueryRequest,CheckResponseUserDto>
{
    public readonly IRepository<Employee> userRepository;

    public CheckUserRequestHandler(IRepository<Employee> userRepository)
    {
        this.userRepository = userRepository;
    }
    public async Task<CheckResponseUserDto> Handle(CheckUserQueryRequest request,CancellationToken token)
    {
        var dto = new CheckResponseUserDto();
        var user = await 
            this.userRepository.GetByFilterAsync(x => x.UserName == request.Username && x.Password == request.Password
            
            );
        if (user == null)
        {
            dto.isExist = false;
        }
        else
        {
            dto.isExist = true;
            dto.Username = request.Username;
            dto.Username = user.UserName;
            dto.Id = user.Id;
            dto.nameSurname = user.NameSurname;

        }

        return dto;

    }
    
    
}