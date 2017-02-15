namespace PurchasingCRM.Data.Model.ORM.Entity
{
    
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CompanyFile")]
    public partial class CompanyFile:BaseEntity
    {
        public int ID { get; set; }

        public int CompanyID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        public string FilePath { get; set; }

        public virtual Company Company { get; set; }
    }
}
