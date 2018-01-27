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
    
    public partial class Subdistributor
    {
        public Subdistributor()
        {
            this.SubdistributorEmployees = new HashSet<SubdistributorEmployee>();
            this.SubdistributorContacts = new HashSet<SubdistributorContact>();
            this.CropsXMunicipality = new HashSet<SubdistributorCropsXMunicipality>();
            this.CommercialNames = new HashSet<SubdistributorCommercialName>();
            this.Contracts = new HashSet<ContractSubdistributor>();
            this.Addresses = new HashSet<AddressesXSubdistributor>();
        }
    
        public int Id { get; set; }
        public string IdB { get; set; }
        public int RTVCreator_BayerEmployeeId { get; set; }
        public Nullable<int> RTV_BayerEmployeeId { get; set; }
        public string Type { get; set; }
        public string BusinessName { get; set; }
        public string BNLegalRepresentative { get; set; }
        public int BNAddressId { get; set; }
        public string WebSite { get; set; }
        public string GeolocationLatitude { get; set; }
        public string GeolocationLongitude { get; set; }
        public decimal LastContractTotalGoal { get; set; }
        public decimal LastContractTotalPurchased { get; set; }
    
        public virtual Address BNAddress { get; set; }
        public virtual ICollection<SubdistributorEmployee> SubdistributorEmployees { get; set; }
        public virtual BayerEmployee RTV_BayerEmployee { get; set; }
        public virtual BayerEmployee RTVCreator_BayerEmployee { get; set; }
        public virtual ICollection<SubdistributorContact> SubdistributorContacts { get; set; }
        public virtual ICollection<SubdistributorCropsXMunicipality> CropsXMunicipality { get; set; }
        public virtual ICollection<SubdistributorCommercialName> CommercialNames { get; set; }
        public virtual ICollection<ContractSubdistributor> Contracts { get; set; }
        public virtual ICollection<AddressesXSubdistributor> Addresses { get; set; }
        public virtual ContractSubdistributor CurrentContract { get; set; }
    }
}