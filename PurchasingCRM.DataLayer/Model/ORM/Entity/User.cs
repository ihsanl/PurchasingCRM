namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("User")]
    public partial class User:BaseEntity
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        public byte? PositionID { get; set; }

        public virtual Position Position { get; set; }

        public virtual UserDetail UserDetail { get; set; }
    }
}
