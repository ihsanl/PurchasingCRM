namespace PurchasingCRM.Data.Model.ORM.Entity
{
  
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CompanyUser")]
    public partial class CompanyUser
    {
       public CompanyUser()
        {
            Appointment = new HashSet<Appointment>();
            RequestProductOffer = new HashSet<RequestProductOffer>();
        }

        public int ID { get; set; }

        public int CompanyID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(150)]
        public string SurName { get; set; }

        [Column("E_Mail")]
        [StringLength(50)]
        public string E_Mail { get; set; }

        [StringLength(11)]
        public string Phone { get; set; }

        [Required]
        [StringLength(100)]
        public string Degree { get; set; }

        public virtual ICollection<Appointment> Appointment { get; set; }

        public virtual Company Company { get; set; }

        public virtual ICollection<RequestProductOffer> RequestProductOffer { get; set; }
    }
}
