using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment2.MyEntities
{
    [Table("Customer")]
    public class Customer
    {   [Key]
        [StringLength(3)]
        public int Cid { get; set; }
        [Required]

        public string Cname { get; set; }
        [Required]
        public string EmailId { get; set; }
        [Required]
        public string MobileNo { get; set; }
        public string City { get; set; }

    }
}
