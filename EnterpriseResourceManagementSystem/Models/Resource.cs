namespace EnterpriseResourceManagementSystem.Models
{
    public class Resource
    {
        public int ResourceId { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Location { get; set; }

        public int Capacity { get; set; }

        public string Facilities { get; set; }

        public string Status { get; set; }namespace EnterpriseResourceManagementSystem.Models
    {
        public class Resource
        {
            public int ResourceId { get; set; }

            public string Name { get; set; }

            public string Type { get; set; }

            public string Location { get; set; }

            public int Capacity { get; set; }

            public string Facilities { get; set; }

            public string Status { get; set; }

            public string Description { get; set; }

            public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
        }
    }

    public string Description { get; set; }

        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
