//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task_10.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Major
    {
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> faculitiy_id { get; set; }
    
        public virtual Faculty Faculty { get; set; }
    }
}
