namespace PurchasingCRM.Data.Model.ORM.Entity
{
    
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Province")]
    public partial class Province:BaseEntity
    {
        public Province()
        {
            Company = new HashSet<Company>();
        }

        public int ID { get; set; }

        public short CountryID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Company> Company { get; set; }

        public virtual Country Country { get; set; }
    }
}
