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
    
    public partial class ContractDistributor
    {
        public int Id { get; set; }
        public string IdB { get; set; }
        public int ContractDistributorStatusId { get; set; }
        public int DistributorId { get; set; }
        public int GRVBayerEmployeeId { get; set; }
        public int RTVBayerEmployeeId { get; set; }
        public int Year { get; set; }
        public Nullable<System.DateTime> ContractDate { get; set; }
        public string RegisteredZoneName { get; set; }
        public string RegisteredRegionName { get; set; }
        public int DiscountType { get; set; }
        public string ContractFilePath { get; set; }
        public decimal AmountGoalQ1Pre { get; set; }
        public decimal AmountGoalQ1 { get; set; }
        public decimal AmountGoalQ2Pre { get; set; }
        public decimal AmountGoalQ2 { get; set; }
        public decimal AmountGoalQ3Pre { get; set; }
        public decimal AmountGoalQ3 { get; set; }
        public decimal AmountGoalQ4Pre { get; set; }
        public decimal AmountGoalQ4 { get; set; }
        public decimal AmountGoalTotalPre { get; set; }
        public decimal AmountGoalTotal { get; set; }
    
        public virtual Distributor Distributor { get; set; }
        public virtual BayerEmployee GRVBayerEmployee { get; set; }
        public virtual BayerEmployee RTVBayerEmployee { get; set; }
        public virtual Cat_ContractDistributorStatus ContractDistributorStatus { get; set; }
    }
}