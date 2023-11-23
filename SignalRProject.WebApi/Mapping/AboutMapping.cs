using AutoMapper;
using SignalRProject.DtoLayer.AboutDto;
using SignalRProject.EntityLayer.Entities;

namespace SignalRProject.WebApi.Mapping
{
    public class AboutMapping : Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, GetAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
        }
    }
}
