using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.EntityLayer.Entities
{
    public class SocialMedia
    {
        public int SocialMediaId { get; set; }
        public string Title { get; set; }
        public string SocialMediaAccountUrl { get; set; }
        public string IconUrl { get; set; }

    }
}
