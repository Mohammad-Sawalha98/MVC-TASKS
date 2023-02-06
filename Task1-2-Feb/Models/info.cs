//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task1_2_Feb.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class info
    {
        public int id { get; set; }
        
        [Required(ErrorMessage = "Required First Name")]
        [Display(Name = "First Name")]
        [StringLength(12)]
        public string First_Name { get; set; }

        [Required(ErrorMessage = "Required Last Name")]
        [Display(Name = "Last Name")]
        [StringLength(12)]
        public string Last_Name { get; set; }

        [Required(ErrorMessage = "Required Email")]
        [Display(Name = "Email")]
        [EmailAddress]
        public string E_mail { get; set; }
        [Required]
        [RegularExpression("((079)|(078)|(077)){1}[0-9]{7}", ErrorMessage = "Number must be Joirdanian")]
        public string Phone { get; set; }

        [Range(18, 50, ErrorMessage = "Required Age")]
        [Required]
        public Nullable<int> Age { get; set; }

        [Display(Name = "Job Title")]
        public string Job_Title { get; set; }

        public Nullable<bool> Gender { get; set; }
        public string Image { get; set; }
        public string CV { get; set; }
    }
}
