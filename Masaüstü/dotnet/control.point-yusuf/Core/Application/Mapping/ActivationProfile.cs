using AutoMapper;
using ITM_Server.Core.Application.Dto;
using ITM_Server.Core.Domain;

namespace ITM_Server.Core.Application.Mapping;

public class ActivationProfile : Profile
{
    public ActivationProfile()
    {
        this.CreateMap<OperationActivation,ActivationListDto>().ReverseMap();
    }
    
}