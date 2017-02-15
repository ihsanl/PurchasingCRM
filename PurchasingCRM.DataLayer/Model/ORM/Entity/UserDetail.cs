namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserDetail")]
    public partial class UserDetail:BaseEntity
    {
        public UserDetail()
        {
            Authorities = new HashSet<Authorities>();
            Request = new HashSet<Request>();
        }

        public int ID { get; set; }
        public int UserID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public byte? DepartmentID { get; set; }

        [StringLength(11)]
        public string TC { get; set; }

        [Column("E_Mail")]
        [StringLength(50)]
        public string E_Mail { get; set; }

        [StringLength(500)]
        public string Image { get; set; }

        [StringLength(11)]
        public string Phone { get; set; }

        [StringLength(11)]
        public string Fax { get; set; }

        [StringLength(250)]
        public string Adress { get; set; }

        public virtual ICollection<Authorities> Authorities { get; set; }

        public virtual Department Department { get; set; }

        public virtual ICollection<Request> Request { get; set; }

        public virtual User User { get; set; }
    }
}
