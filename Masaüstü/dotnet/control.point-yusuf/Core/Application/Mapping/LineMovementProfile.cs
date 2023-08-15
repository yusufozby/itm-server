using AutoMapper;
using ITM_Server.Core.Application.Dto;
using ITM_Server.Core.Domain;

namespace ITM_Server.Core.Application.Mapping;

public class LineMovementProfile : Profile
{
    public LineMovementProfile()
    {
        this.CreateMap<LineMovement, LineMovementDto>().ReverseMap();
    }
}