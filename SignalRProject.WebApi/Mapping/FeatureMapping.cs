using AutoMapper;
using SignalRProject.DtoLayer.FeatureDto;
using SignalRProject.EntityLayer.Entities;

namespace SignalRProject.WebApi.Mapping
{
    public class FeatureMapping : Profile
    {
        public FeatureMapping()
        {
            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, GetFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
        }
    }
}
