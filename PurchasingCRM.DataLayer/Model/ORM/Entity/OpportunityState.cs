namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("OpportunityState")]
    public partial class OpportunityState:BaseEntity
    {
        public OpportunityState()
        {
            Opportunity = new HashSet<Opportunity>();
        }

      
        public byte ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Opportunity> Opportunity { get; set; }
    }
}
