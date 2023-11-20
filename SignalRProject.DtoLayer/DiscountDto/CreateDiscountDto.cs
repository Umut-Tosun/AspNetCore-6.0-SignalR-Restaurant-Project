using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.DtoLayer.DiscountDto
{
    public class CreateDiscountDto
    {
       
        public string DiscountTitle { get; set; }
        public decimal DiscountAmount { get; set; }
        public string DiscountDescription { get; set; }
        public string DiscountImageUrl { get; set; }
    }
}
