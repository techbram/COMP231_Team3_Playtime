using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoCode.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string Desc { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Imagelg { get; set; }
        
        [Required]
        public string ImageSm { get; set; }
        
        [Required]
        public string AgeGroup { get; set; }

        [Required]
        public bool IsActive { get; set; }

    }
}