namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Form")]
    public partial class Form:BaseEntity
    {
       public Form()
        {
            Authorities = new HashSet<Authorities>();
        }

       
        public byte ID { get; set; }

        [StringLength(50)]
        public string Adi { get; set; }

        public virtual ICollection<Authorities> Authorities { get; set; }
    }
}
