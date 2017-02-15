namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Vat")]
    public partial class Vat:BaseEntity
    {
         public Vat()
        {
            Product = new HashSet<Product>();
        }

        public byte ID { get; set; }

        [Column("Vat")]
        public byte? Vat1 { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
