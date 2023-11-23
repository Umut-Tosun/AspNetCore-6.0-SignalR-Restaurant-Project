using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRProject.BusinessLayer.Abstract;
using SignalRProject.DtoLayer.TestimonialDto;
using SignalRProject.EntityLayer.Entities;

namespace SignalRProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _TestimonialService;

        public TestimonialController(ITestimonialService TestimonialService)
        {
            _TestimonialService = TestimonialService;
        }

        [HttpGet]
        public IActionResult TestimonialList()
        {
            var values = _TestimonialService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateTestimonial(CreateTestimonialDto createTestimonialDto)
        {
            Testimonial Testimonial = new Testimonial()
            {
                CommentText = createTestimonialDto.CommentText,
                CommentTitle = createTestimonialDto.CommentTitle,
                FullName = createTestimonialDto.FullName,
                Status = createTestimonialDto.Status,
                TestimonialImageUrl = createTestimonialDto.TestimonialImageUrl

            };
            _TestimonialService.Tadd(Testimonial);
            return Ok("Referans başarıyla eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteTestimonial(int id)
        {
            var value = _TestimonialService.TGetById(id);
            _TestimonialService.Tdelete(value);
            return Ok("Referans silindi.");
        }
        [HttpPut]
        public IActionResult UpdateTestimonial(UpdateTestimonialDto updateTestimonialDto)
        {
            Testimonial Testimonial = new Testimonial()
            {
                TestimonialId = updateTestimonialDto.TestimonialId,
                CommentText = updateTestimonialDto.CommentText,
                CommentTitle = updateTestimonialDto.CommentTitle,
                FullName = updateTestimonialDto.FullName,
                Status = updateTestimonialDto.Status,
                TestimonialImageUrl = updateTestimonialDto.TestimonialImageUrl

            };
            _TestimonialService.Tupdate(Testimonial);
            return Ok("Referans alanı güncellendi.");
        }
        [HttpGet("GetTestimonial")]
        public IActionResult GetTestimonial(int id)
        {
            var value = _TestimonialService.TGetById(id);
            return Ok(value);
        }
    }
}
