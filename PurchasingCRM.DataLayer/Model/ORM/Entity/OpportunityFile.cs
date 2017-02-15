namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("OpportunityFile")]
    public partial class OpportunityFile:BaseEntity
    {
        public int ID { get; set; }

        public int OpportunityID { get; set; }

        [StringLength(150)]
        public string FileName { get; set; }

        public string FilePath { get; set; }

        public virtual Opportunity Opportunity { get; set; }
    }
}
