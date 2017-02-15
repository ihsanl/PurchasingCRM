namespace PurchasingCRM.Data.Model.ORM.Entity
{
 
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Country")]
    public partial class Country:BaseEntity
    {
       public Country()
        {
            Company = new HashSet<Company>();
            Province = new HashSet<Province>();
        }

        public short ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Company> Company { get; set; }

         public virtual ICollection<Province> Province { get; set; }
    }
}
