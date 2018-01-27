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
    
    public partial class DistributorBranch
    {
        public DistributorBranch()
        {
            this.DistributorBranchContacts = new HashSet<DistributorBranchContact>();
        }
    
        public int Id { get; set; }
        public int DistributorId { get; set; }
        public int AddressId { get; set; }
        public string Name { get; set; }
        public string GeolocationLongitude { get; set; }
        public string GeolocationLatitude { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual ICollection<DistributorBranchContact> DistributorBranchContacts { get; set; }
        public virtual Distributor Distributor { get; set; }
    }
}