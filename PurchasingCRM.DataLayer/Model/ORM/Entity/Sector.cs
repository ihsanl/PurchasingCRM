namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Sector")]
    public partial class Sector:BaseEntity
    {
        public Sector()
        {
            Company = new HashSet<Company>();
        }

  
        public byte ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

         public virtual ICollection<Company> Company { get; set; }
    }
}
