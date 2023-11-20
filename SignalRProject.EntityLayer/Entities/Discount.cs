namespace SignalRProject.EntityLayer.Entities
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public string DiscountTitle { get; set; }
        public decimal DiscountAmount { get; set; }
        public string DiscountDescription { get; set; }
        public string DiscountImageUrl { get; set; }

    }
}
