namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Currency")]
    public partial class Currency:BaseEntity
    {
        public Currency()
        {
            CompanyPayment = new HashSet<CompanyPayment>();
            Opportunity = new HashSet<Opportunity>();
        }

       
        public byte ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Name { get; set; }

        public virtual ICollection<CompanyPayment> CompanyPayment { get; set; }

        public virtual ICollection<Opportunity> Opportunity { get; set; }
    }
}
