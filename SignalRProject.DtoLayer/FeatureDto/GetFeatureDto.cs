using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.DtoLayer.FeatureDto
{
    public class GetFeatureDto
    {
        public int FeatureId { get; set; }
        public string FeatureTitle { get; set; }
        public string FeatureDescription { get; set; }
    }
}
