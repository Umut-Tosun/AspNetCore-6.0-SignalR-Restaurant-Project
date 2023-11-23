using AutoMapper;
using SignalRProject.DtoLayer.ContactDto;
using SignalRProject.EntityLayer.Entities;

namespace SignalRProject.WebApi.Mapping
{
    public class ContactMapping : Profile
    {
        public ContactMapping()
        {
            CreateMap<Contact, ResultContactDto>().ReverseMap();
            CreateMap<Contact, GetContactDto>().ReverseMap();
            CreateMap<Contact, UpdateContactDto>().ReverseMap();
            CreateMap<Contact, CreateContactDto>().ReverseMap();
        }
    }
}
