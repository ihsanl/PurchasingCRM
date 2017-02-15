namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BankBranch")]
    public partial class BankBranch:BaseEntity
    {
        public BankBranch()
        {
            CompanyBank = new HashSet<CompanyBank>();
        }

        public int ID { get; set; }

        public byte BankID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

         public virtual ICollection<CompanyBank> CompanyBank { get; set; }
    }
}
