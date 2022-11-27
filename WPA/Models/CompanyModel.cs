using System;
using System.ComponentModel.DataAnnotations;

namespace WPA.Models
{
    public class CompanyModel
    {
        [Key]
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public int Rating { get; set; }

    }
}
