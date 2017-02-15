namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("OpportunityProduct")]
    public partial class OpportunityProduct:BaseEntity
    {
        public int ID { get; set; }

        public int? OpportunityID { get; set; }

        public int? ProductID { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public decimal? Amount { get; set; }

        public byte? ProductUnitID { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public virtual Opportunity Opportunity { get; set; }

        public virtual Product Product { get; set; }

        public virtual ProductUnit ProductUnit { get; set; }
    }
}
