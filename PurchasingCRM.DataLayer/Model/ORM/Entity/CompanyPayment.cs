namespace PurchasingCRM.Data.Model.ORM.Entity
{
    
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CompanyPayment")]
    public partial class CompanyPayment:BaseEntity
    {
        public int ID { get; set; }

        public int CompanyID { get; set; }

        public byte CurrencyID { get; set; }

        public byte PaymentMethodID { get; set; }

        public decimal Total { get; set; }

        public virtual Company Company { get; set; }

        public virtual Currency Currency { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }
    }
}
