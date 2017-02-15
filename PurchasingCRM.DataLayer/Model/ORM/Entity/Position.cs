namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Position")]
    public partial class Position:BaseEntity
    {
         public Position()
        {
            Authorities = new HashSet<Authorities>();
            User = new HashSet<User>();
        }

  
        public byte ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string IdentityName { get; set; }
        public virtual ICollection<Authorities> Authorities { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
