namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ProductUnit")]
    public partial class ProductUnit:BaseEntity
    {
        public ProductUnit()
        {
            OpportunityProduct = new HashSet<OpportunityProduct>();
            Product = new HashSet<Product>();
            RequestProduct = new HashSet<RequestProduct>();
        }

        
        public byte ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<OpportunityProduct> OpportunityProduct { get; set; }

        public virtual ICollection<Product> Product { get; set; }

        public virtual ICollection<RequestProduct> RequestProduct { get; set; }
    }
}
