using System;
using System.ComponentModel.DataAnnotations;

namespace WPA.Models
{
    public class CompanyModel
    {
        [Key]
        public Guid CompanyId { get; set; }
        public string Name { get; set; }
        public int Rating { get; set; }

    }
}
