using ApiProjectCamp.WebApi.Dtos.FeatureDtos;
using ApiProjectCamp.WebApi.Dtos.MessageDtos;
using ApiProjectCamp.WebApi.Entities;
using AutoMapper;

namespace ApiProjectCamp.WebApi.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetByIDFeatureDto>().ReverseMap();

            CreateMap<Message, ResultMessageDto>().ReverseMap();
            CreateMap<Message, CreateMessageDto>().ReverseMap();
            CreateMap<Message, UpdateMessageDto>().ReverseMap();
            CreateMap<Message, GetByIDMessageDto>().ReverseMap();
        }
    }
}
