using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public bool Active { get; set; }
    }
}
