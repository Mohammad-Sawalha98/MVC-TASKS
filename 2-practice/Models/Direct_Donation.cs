//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _2_practice.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Direct_Donation
    {
        public int Id_direct { get; set; }
        public string Full_name { get; set; }
        public Nullable<decimal> Phone { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public Nullable<System.DateTime> Donation_date { get; set; }
        public Nullable<int> Quantity { get; set; }
        public string Details { get; set; }
        public Nullable<int> state { get; set; }
        public string Email { get; set; }
        public Nullable<int> taken { get; set; }
        public Nullable<int> Id_campaigns { get; set; }
    
        public virtual Campaign Campaign { get; set; }
    }
}
