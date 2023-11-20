using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.DtoLayer.SocialMediaDto
{
    public class CreateSocialMediaDto
    {
        
        public string Title { get; set; }
        public string SocialMediaAccountUrl { get; set; }
        public string IconUrl { get; set; }
    }
}
