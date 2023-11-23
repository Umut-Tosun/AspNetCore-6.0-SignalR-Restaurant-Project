using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalRProject.BusinessLayer.Abstract;
using SignalRProject.DataAccessLayer.Concrete;
using SignalRProject.DtoLayer.ProductDto;
using SignalRProject.EntityLayer.Entities;

namespace SignalRProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _ProductService;
        private readonly IMapper _mapper;

        public ProductController(IProductService ProductService,IMapper mapper)
        {
            _ProductService = ProductService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var values = _ProductService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var context = new Context();
            var values = context.products.Include(x => x.Category).Select(y => new ResultProductWithCategory
            {
                ProductDescription = y.ProductDescription,
                ProductName = y.ProductName,
                CategoryName = y.Category.CategoryName,
                ProductId = y.ProductId,
                ProductImageUrl = y.ProductImageUrl,
                ProductPrice = y.ProductPrice,
                ProductStatus = y.ProductStatus
            }).ToList();
          
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            Product Product = new Product()
            {
                ProductDescription = createProductDto.ProductDescription,
                ProductImageUrl = createProductDto.ProductImageUrl,
                ProductName = createProductDto.ProductName,
                ProductPrice = createProductDto.ProductPrice,
                ProductStatus = createProductDto.ProductStatus,

            };
            _ProductService.Tadd(Product);
            return Ok("Ürün kısmı başarıyla eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var value = _ProductService.TGetById(id);
            _ProductService.Tdelete(value);
            return Ok("Ürün alanı silindi.");
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            Product Product = new Product()
            {
                ProductId = updateProductDto.ProductId,
                ProductDescription = updateProductDto.ProductDescription,
                ProductImageUrl = updateProductDto.ProductImageUrl,
                ProductName = updateProductDto.ProductName,
                ProductPrice = updateProductDto.ProductPrice,
                ProductStatus = updateProductDto.ProductStatus,

            };
            _ProductService.Tupdate(Product);
            return Ok("Ürün alanı güncellendi.");
        }
        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            var value = _ProductService.TGetById(id);
            return Ok(value);
        }
    }
}
