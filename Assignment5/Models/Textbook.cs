using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class Textbook
    {
        [Required]
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthFirst { get; set; }
        [Required]
        public string AuthLast { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        [RegularExpression(@"^(1-)?\d{3}-\d{10}$", ErrorMessage = "Must be in proper ISBN 13 format")]
        public string ISBN { get; set; }
        [Required]
        public string Cat { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Pages { get; set; }
    }
}
