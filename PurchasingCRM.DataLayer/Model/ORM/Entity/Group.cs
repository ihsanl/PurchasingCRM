namespace PurchasingCRM.Data.Model.ORM.Entity
{
  
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Group")]
    public partial class Group:BaseEntity
    {
       public Group()
        {
            Company = new HashSet<Company>();
        }

      
        public byte ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Company> Company { get; set; }
    }
}
