using System;
using System.Collections.Generic;
using System.Configuration; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; 
using System.ComponentModel.DataAnnotations;

namespace Tuffab.Models
{
    public class SitePicture
    {


        [Key]
        [Display(AutoGenerateField = true, Name ="I.D.")]
        public int ID { get; set;  }

        [Display(AutoGenerateField =false, Name ="Data", Description ="Image bytes")]
        [Required]
        public byte[] Data { get; set;  }

        [Display(Name ="Caption")]
        [Required]
        [MaxLength(100,ErrorMessage ="Must be less than 100 characters long")]
        
        public string Caption { get; set; } = "Default Caption";


        
        public string Filename { get; set; }

        
        public string ContentType { get; set; }


        [Display(Name ="Width")]
        [Required]
        public int Width { get; set; } = 640;

        [Display(Name = "Height")]
        [Required]
        public int Height { get; set; } = 480; 


        public SitePicture()
        {
            //Width = 640;
            //Height = 480; 
        }

    }
    
}
