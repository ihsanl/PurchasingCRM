namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Source")]
    public partial class Source:BaseEntity
    {
         public Source()
        {
            Company = new HashSet<Company>();
            Opportunity = new HashSet<Opportunity>();
        }

    
        public byte ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

         public virtual ICollection<Company> Company { get; set; }

         public virtual ICollection<Opportunity> Opportunity { get; set; }
    }
}
