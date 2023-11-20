using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.DtoLayer.AboutDto
{
    public class CreateAboutDto
    {
        public string AboutTitle { get; set; }
        public string AboutDescription { get; set; }
        public string AboutImageUrl { get; set; }
    }
}
