namespace PurchasingCRM.Data.Model.ORM.Entity
{

    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ProductType")]
    public partial class ProductType:BaseEntity
    {
       
        public ProductType()
        {
            Product = new HashSet<Product>();
        }

     
        public byte ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
