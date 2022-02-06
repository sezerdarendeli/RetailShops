using System;

namespace RetailShops.Domain.Shared
{
    public class UserResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public int UserType { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
