using Microsoft.AspNetCore.Identity;

namespace EnterpriseResourceManagementSystem.Models
{
    public class ApplicationUser : IdentityUser<int>
    {
        public string Name { get; set; }

        public string Department { get; set; }

        public ICollection<Booking> Bookings { get; set; } 
    }
}