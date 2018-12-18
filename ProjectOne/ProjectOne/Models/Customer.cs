using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ProjectOne.Models
{
    public class Customer
    {
        [Display(Name = "Id")]
        public int CustomerID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public List<Address> Address { get; set; }

        public List<OrderHeader> OrderHeaders { get; set; }

        public string CustomerPassword { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
