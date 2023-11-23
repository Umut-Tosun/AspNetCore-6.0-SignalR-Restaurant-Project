using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRProject.BusinessLayer.Abstract;
using SignalRProject.DtoLayer.FeatureDto;
using SignalRProject.EntityLayer.Entities;

namespace SignalRProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _FeatureService;

        public FeatureController(IFeatureService FeatureService)
        {
            _FeatureService = FeatureService;
        }

        [HttpGet]
        public IActionResult FeatureList()
        {
            var values = _FeatureService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            Feature Feature = new Feature()
            {
               FeatureDescription = createFeatureDto.FeatureDescription,
               FeatureTitle = createFeatureDto.FeatureTitle,

            };
            _FeatureService.Tadd(Feature);
            return Ok("Hakkımda kısmı başarıyla eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteFeature(int id)
        {
            var value = _FeatureService.TGetById(id);
            _FeatureService.Tdelete(value);
            return Ok("Hakkımda alanı silindi.");
        }
        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            Feature Feature = new Feature()
            {
                FeatureId = updateFeatureDto.FeatureId,
                FeatureDescription = updateFeatureDto.FeatureDescription,
                FeatureTitle = updateFeatureDto.FeatureTitle,

            };
            _FeatureService.Tupdate(Feature);
            return Ok("Hakkımda alanı güncellendi.");
        }
        [HttpGet("GetFeature")]
        public IActionResult GetFeature(int id)
        {
            var value = _FeatureService.TGetById(id);
            return Ok(value);
        }
    }
}
