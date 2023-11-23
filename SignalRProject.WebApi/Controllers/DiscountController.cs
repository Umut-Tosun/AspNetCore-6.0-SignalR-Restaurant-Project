using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRProject.BusinessLayer.Abstract;
using SignalRProject.DtoLayer.DiscountDto;
using SignalRProject.EntityLayer.Entities;


namespace SignalRProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _DiscountService;

        public DiscountController(IDiscountService DiscountService)
        {
            _DiscountService = DiscountService;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {
            var values = _DiscountService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            Discount Discount = new Discount()
            {
                DiscountAmount = createDiscountDto.DiscountAmount,
                DiscountDescription = createDiscountDto.DiscountDescription,
                DiscountImageUrl = createDiscountDto.DiscountImageUrl,
                DiscountTitle = createDiscountDto.DiscountTitle,

            };
            _DiscountService.Tadd(Discount);
            return Ok("İndirim Bilgisi Alanı başarıyla eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _DiscountService.TGetById(id);
            _DiscountService.Tdelete(value);
            return Ok("İndirim Bilgisi Alanı silindi.");
        }
        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            Discount Discount = new Discount()
            {
                DiscountId = updateDiscountDto.DiscountId,
                DiscountAmount = updateDiscountDto.DiscountAmount,
                DiscountDescription = updateDiscountDto.DiscountDescription,
                DiscountImageUrl = updateDiscountDto.DiscountImageUrl,
                DiscountTitle = updateDiscountDto.DiscountTitle,

            };
            _DiscountService.Tupdate(Discount);
            return Ok("İndirim Bilgisi Alanı güncellendi.");
        }
        [HttpGet("GetDiscount")]
        public IActionResult GetDiscount(int id)
        {
            var value = _DiscountService.TGetById(id);
            return Ok(value);
        }
    }
}
