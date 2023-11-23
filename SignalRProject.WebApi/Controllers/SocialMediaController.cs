using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRProject.BusinessLayer.Abstract;
using SignalRProject.DtoLayer.SocialMediaDto;
using SignalRProject.EntityLayer.Entities;

namespace SignalRProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _SocialMediaService;

        public SocialMediaController(ISocialMediaService SocialMediaService)
        {
            _SocialMediaService = SocialMediaService;
        }

        [HttpGet]
        public IActionResult SocialMediaList()
        {
            var values = _SocialMediaService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateSocialMedia(CreateSocialMediaDto createSocialMediaDto)
        {
            SocialMedia SocialMedia = new SocialMedia()
            {
               IconUrl = createSocialMediaDto.IconUrl,
               SocialMediaAccountUrl = createSocialMediaDto.SocialMediaAccountUrl,
               Title = createSocialMediaDto.Title,

            };
            _SocialMediaService.Tadd(SocialMedia);
            return Ok("Sosyal Medya Hesabı başarıyla eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteSocialMedia(int id)
        {
            var value = _SocialMediaService.TGetById(id);
            _SocialMediaService.Tdelete(value);
            return Ok("Sosyal Medya Hesabı silindi.");
        }
        [HttpPut]
        public IActionResult UpdateSocialMedia(UpdateSocialMediaDto updateSocialMediaDto)
        {
            SocialMedia SocialMedia = new SocialMedia()
            {
                SocialMediaId = updateSocialMediaDto.SocialMediaId,
                IconUrl = updateSocialMediaDto.IconUrl,
                SocialMediaAccountUrl = updateSocialMediaDto.SocialMediaAccountUrl,
                Title = updateSocialMediaDto.Title,

            };
            _SocialMediaService.Tupdate(SocialMedia);
            return Ok("Sosyal Medya Hesabı alanı güncellendi.");
        }
        [HttpGet("GetSocialMedia")]
        public IActionResult GetSocialMedia(int id)
        {
            var value = _SocialMediaService.TGetById(id);
            return Ok(value);
        }
    }
}
