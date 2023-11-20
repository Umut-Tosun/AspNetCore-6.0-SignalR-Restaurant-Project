namespace SignalRProject.EntityLayer.Entities
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Mail { get; set; }
        public string PhoneNumber { get; set; }
        public int PersonCount { get; set; }
        public DateTime Date { get; set; }
    }
}
