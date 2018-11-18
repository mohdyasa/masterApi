using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace masterApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string DOB { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public bool isDeleted { get; set; }
    }
}