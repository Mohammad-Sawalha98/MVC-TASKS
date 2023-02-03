using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practice2.Models
{
    public class info
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name must be less than 100 characters.")]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}