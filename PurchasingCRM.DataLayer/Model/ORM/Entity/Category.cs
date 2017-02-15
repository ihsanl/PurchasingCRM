namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    [Table("Category")]
    public partial class Category:BaseEntity
    {
        public Category()
        {
            Category1 = new HashSet<Category>();
            Product = new HashSet<Product>();
        }

        public int ID { get; set; }

        public int? ParentID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Category> Category1 { get; set; }

        public virtual Category Category2 { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
