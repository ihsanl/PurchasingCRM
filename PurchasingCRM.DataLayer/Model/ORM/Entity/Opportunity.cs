namespace PurchasingCRM.Data.Model.ORM.Entity
{
  
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Opportunity")]
    public partial class Opportunity:BaseEntity
    {
       public Opportunity()
        {
            OpportunityFile = new HashSet<OpportunityFile>();
            OpportunityProduct = new HashSet<OpportunityProduct>();
        }

        public int ID { get; set; }

        public byte OpportunityStateID { get; set; }

        public byte? SourceID { get; set; }

        public decimal? Advice { get; set; }

        [StringLength(50)]
        public string OpportunityNo { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public int? CompanyID { get; set; }

        public byte? OpportunityCategoryID { get; set; }

        public float? Price { get; set; }

        public byte? CurrencyID { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public virtual Company Company { get; set; }

        public virtual Currency Currency { get; set; }

        public virtual OpportunityCategory OpportunityCategory { get; set; }

        public virtual OpportunityState OpportunityState { get; set; }

        public virtual Source Source { get; set; }

        public virtual ICollection<OpportunityFile> OpportunityFile { get; set; }

       public virtual ICollection<OpportunityProduct> OpportunityProduct { get; set; }
    }
}
