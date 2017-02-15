namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Brand")]
    public partial class Brand:BaseEntity
    {
        public Brand()
        {
            Product = new HashSet<Product>();
        }

      
        public byte ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
