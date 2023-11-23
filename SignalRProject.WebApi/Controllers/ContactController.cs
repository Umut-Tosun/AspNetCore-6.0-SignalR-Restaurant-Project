using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRProject.BusinessLayer.Abstract;
using SignalRProject.DtoLayer.ContactDto;
using SignalRProject.EntityLayer.Entities;

namespace SignalRProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _ContactService;

        public ContactController(IContactService ContactService)
        {
            _ContactService = ContactService;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var values = _ContactService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            Contact Contact = new Contact()
            {
                PhoneNumber = createContactDto.PhoneNumber,
                ContactFooterTitle = createContactDto.ContactFooterTitle,
                Location = createContactDto.Location,
                Mail = createContactDto.Mail,

            };
            _ContactService.Tadd(Contact);
            return Ok("İletişim Bilgisi başarıyla eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteContact(int id)
        {
            var value = _ContactService.TGetById(id);
            _ContactService.Tdelete(value);
            return Ok("İletişim Bilgisi Alanı silindi.");
        }
        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            Contact Contact = new Contact()
            {
                ContactId = updateContactDto.ContactId,
                ContactFooterTitle = updateContactDto.ContactFooterTitle,
                Location = updateContactDto.Location,
                Mail = updateContactDto.Mail,

            };
            _ContactService.Tupdate(Contact);
            return Ok("İletişim Alanı güncellendi.");
        }
        [HttpGet("GetContact")]
        public IActionResult GetContact(int id)
        {
            var value = _ContactService.TGetById(id);
            return Ok(value);
        }
    }
}
