using ITM_Server.Core.Application.Dto;
using ITM_Server.Core.Application.Features.CORS.Queries;
using ITM_Server.Core.Application.Interfaces;
using ITM_Server.Core.Domain;
using MediatR;

namespace ITM_Server.Core.Application.Features.CORS.Handlers;

public class CheckUserRequestHandler : IRequestHandler<CheckUserQueryRequest,CheckResponseUserDto>
{
    public readonly IRepository<Employee> userRepository;
    public readonly IRepository<Job> jobRepository;

    public CheckUserRequestHandler(IRepository<Employee> userRepository,IRepository<Job> jobRepository)
    {
        this.userRepository = userRepository;
        this.jobRepository = jobRepository;
    }
    public async Task<CheckResponseUserDto> Handle(CheckUserQueryRequest request,CancellationToken token)
    {
        var dto = new CheckResponseUserDto();
        var job = await this.jobRepository.GetByFilterAsync(x => x.Name == request.job);
        var user = await this.userRepository.GetByFilterAsync(x => x.UserName == request.Username && x.Password == request.Password
            
            );
        if (user == null || job.Id != user.JobId|| job == null)
        {
            dto.isExist = false;
        }
        else
        {
            dto.isExist = true;
            dto.Username = request.Username;
            dto.Username = user.UserName;
            dto.Id = user.Id;
            dto.nameSurname = user.FullName!;

        }

        return dto;

    }
    
    
}