using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
namespace Tuffab.Models
{
    public class QuoteInformation
    {
        [Required]
        [Key()]
        public int ID { get; set; }


        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Phone(ErrorMessage = "Invalid Phone Number")]
        public string Phone { get; set; }

        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        public string Email { get; set;  }

        [Required]
        [Display(Name ="Description")]
        public string Description { get; set; }



    }
}
