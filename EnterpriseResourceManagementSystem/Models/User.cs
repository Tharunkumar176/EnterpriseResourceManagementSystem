namespace EnterpriseResourceManagementSystem.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Department { get; set; }

        public string Role { get; set; }

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
