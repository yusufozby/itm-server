using AutoMapper;
using ITM_Server.Core.Application.Dto;
using ITM_Server.Core.Domain;

namespace ITM_Server.Core.Application.Mapping;

public class VaryantProfile : Profile
{
    public VaryantProfile() 
    {
        this.CreateMap<Varyant,VaryantDto>().ReverseMap();
    }
}