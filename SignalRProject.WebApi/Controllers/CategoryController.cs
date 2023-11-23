using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalRProject.BusinessLayer.Abstract;
using SignalRProject.DtoLayer.CategoryDto;
using SignalRProject.EntityLayer.Entities;

namespace SignalRProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _CategoryService;

        public CategoryController(ICategoryService CategoryService)
        {
            _CategoryService = CategoryService;
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _CategoryService.TGetListAll();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            Category Category = new Category()
            {
                CategoryName = createCategoryDto.CategoryName,
                CategoryStatus = createCategoryDto.CategoryStatus,

            };
            _CategoryService.Tadd(Category);
            return Ok("Kategori başarıyla eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var value = _CategoryService.TGetById(id);
            _CategoryService.Tdelete(value);
            return Ok("Kategori silindi.");
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            Category Category = new Category()
            {
                CategoryId = updateCategoryDto.CategoryId,
                CategoryName = updateCategoryDto.CategoryName,
                CategoryStatus = updateCategoryDto.CategoryStatus,
            };
            _CategoryService.Tupdate(Category);
            return Ok("Kategori güncellendi.");
        }
        [HttpGet("GetCategory")]
        public IActionResult GetCategory(int id)
        {
            var value = _CategoryService.TGetById(id);
            return Ok(value);
        }
    }
}
