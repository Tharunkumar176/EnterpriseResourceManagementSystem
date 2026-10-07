namespace EnterpriseResourceManagementSystem.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        public int UserId { get; set; }

        public int ResourceId { get; set; }

        public User User { get; set; }

        public Resource Resource { get; set; }

        public BookingDetails BookingDetails { get; set; }
    }
}
