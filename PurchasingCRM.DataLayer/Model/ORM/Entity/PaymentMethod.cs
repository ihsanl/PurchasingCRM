namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PaymentMethod")]
    public partial class PaymentMethod:BaseEntity
    {
         public PaymentMethod()
        {
            CompanyPayment = new HashSet<CompanyPayment>();
        }

        public byte ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public virtual ICollection<CompanyPayment> CompanyPayment { get; set; }
    }
}
