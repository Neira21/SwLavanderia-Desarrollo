using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwLavanderia.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
    }
}