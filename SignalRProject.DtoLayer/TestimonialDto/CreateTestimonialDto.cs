using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRProject.DtoLayer.TestimonialDto
{
    public class CreateTestimonialDto
    {
      
        public string FullName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentText { get; set; }
        public string TestimonialImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
