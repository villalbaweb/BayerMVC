﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PSDModelContainer : DbContext
    {
        public PSDModelContainer()
            : base("name=PSDModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<RolesXUser> RolesXUser { get; set; }
        public virtual DbSet<Cat_UserRole> Cat_UserRole { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Cat_UserStatus> Cat_UserStatus { get; set; }
        public virtual DbSet<Distributor> Distributor { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressMunicipality> AddressMunicipality { get; set; }
        public virtual DbSet<AddressState> AddressState { get; set; }
        public virtual DbSet<AddressColony> AddressColony { get; set; }
        public virtual DbSet<AddressPostalCode> AddressPostalCode { get; set; }
        public virtual DbSet<SubdistributorCommercialName> SubdistributorCommercialName { get; set; }
        public virtual DbSet<Cat_Zone> Cat_Zone { get; set; }
        public virtual DbSet<Cat_Crop> Cat_Crop { get; set; }
        public virtual DbSet<DistributorContact> DistributorContact { get; set; }
        public virtual DbSet<Cat_DistributorContactArea> Cat_DistributorContactArea { get; set; }
        public virtual DbSet<DistributorBranch> DistributorBranch { get; set; }
        public virtual DbSet<DistributorBranchContact> DistributorBranchContact { get; set; }
        public virtual DbSet<Cat_DistributorBranchContactArea> Cat_DistributorBranchContactArea { get; set; }
        public virtual DbSet<Subdistributor> Subdistributor { get; set; }
        public virtual DbSet<AddressesXSubdistributor> AddressesXSubdistributor { get; set; }
        public virtual DbSet<SubdistributorContact> SubdistributorContact { get; set; }
        public virtual DbSet<Cat_SubdistributorContactArea> Cat_SubdistributorContactArea { get; set; }
        public virtual DbSet<SubdistributorCropsXMunicipality> SubdistributorCropsXMunicipality { get; set; }
        public virtual DbSet<DistributorCropsXMunicipality> DistributorCropsXMunicipality { get; set; }
        public virtual DbSet<MunicipalitiesXEmployee> MunicipalitiesXEmployee { get; set; }
        public virtual DbSet<ContractDistributor> ContractDistributor { get; set; }
        public virtual DbSet<Cat_ContractDistributorStatus> Cat_ContractDistributorStatus { get; set; }
        public virtual DbSet<Cat_CropCategory> Cat_CropCategory { get; set; }
        public virtual DbSet<ContentLink> ContentLink { get; set; }
        public virtual DbSet<AppConfiguration> AppConfiguration { get; set; }
        public virtual DbSet<ContractSubdistributor> ContractSubdistributor { get; set; }
        public virtual DbSet<Cat_ContractSubdistributorStatus> Cat_ContractSubdistributorStatus { get; set; }
        public virtual DbSet<DistributorPurchasesXContractSubdistributor> DistributorPurchasesXContractSubdistributor { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsSection> NewsSection { get; set; }
        public virtual DbSet<ContentData> ContentData { get; set; }
        public virtual DbSet<SubdistributorDiscountCoupon> SubdistributorDiscountCoupon { get; set; }
        public virtual DbSet<SubdistributorPromotionCoupon> SubdistributorPromotionCoupon { get; set; }
    }
}