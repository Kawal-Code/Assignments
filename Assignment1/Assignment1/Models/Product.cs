using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Product
    {   [Required]
        public int Pid { get; set; }
        [Required]
        public string Pname { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int stock { get; set; }
    }
}
