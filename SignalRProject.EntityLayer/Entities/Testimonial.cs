
namespace SignalRProject.EntityLayer.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string FullName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentText { get; set; }
        public string TestimonialImageUrl { get; set; }
        public bool Status { get; set; }

    }
}
