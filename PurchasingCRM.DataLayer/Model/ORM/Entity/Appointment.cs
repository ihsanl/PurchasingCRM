namespace PurchasingCRM.Data.Model.ORM.Entity
{
  
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    [Table("Appointment")]
    public partial class Appointment:BaseEntity
    {
        public int ID { get; set; }
        public int? CompanyID { get; set; }

        public int? CompanyUserID { get; set; }

        public bool? IsCustomerSide { get; set; }

        public string Description { get; set; }

        public string OurUser { get; set; }

        public string CompanyUsers { get; set; }

        public bool? State { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? FinishDate { get; set; }

        public virtual Company Company { get; set; }

        public virtual CompanyUser CompanyUser { get; set; }
    }
}
