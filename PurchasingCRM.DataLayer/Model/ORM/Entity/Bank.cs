namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Bank")]
    public partial class Bank:BaseEntity
    {
        public Bank()
        {
            CompanyBank = new HashSet<CompanyBank>();
        }

        public byte ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

       public virtual ICollection<CompanyBank> CompanyBank { get; set; }
    }
}
