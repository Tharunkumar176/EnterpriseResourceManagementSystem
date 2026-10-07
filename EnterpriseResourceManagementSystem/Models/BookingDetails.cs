namespace EnterpriseResourceManagementSystem.Models
{
    public class BookingDetails
    {
        public int BookingDetailsId { get; set; }
        
        public int BookingId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public string Purpose { get; set; }

        public string Status { get; set; }

        public DateTime CreatedAt { get; set; }

        public Booking Booking { get; set; }
    }
}