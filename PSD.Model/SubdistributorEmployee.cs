//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSD.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class SubdistributorEmployee : Person
    {
        public int SubdistributorId { get; set; }
    
        public virtual Subdistributor Subdistributor { get; set; }
    }
}