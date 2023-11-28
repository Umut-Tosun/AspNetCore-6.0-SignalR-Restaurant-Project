using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.DtoLayer.ProductDto
{
    public class CreateProductDto
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }
        public bool ProductStatus { get; set; }
        public string ProductDescription { get; set; }
        public Decimal ProductPrice { get; set; }
        public string ProductImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}
