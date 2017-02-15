namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ContactStatu")]
    public partial class ContactStatu:BaseEntity
    {
       public ContactStatu()
        {
            Contract = new HashSet<Contract>();
        }

        public byte ID { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

       public virtual ICollection<Contract> Contract { get; set; }
    }
}
