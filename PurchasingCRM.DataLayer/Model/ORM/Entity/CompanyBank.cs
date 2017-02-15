namespace PurchasingCRM.Data.Model.ORM.Entity
{
   
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CompanyBank")]
    public partial class CompanyBank:BaseEntity
    {
        public int ID { get; set; }

        public int CompanyID { get; set; }

        public byte BankID { get; set; }

        public int? BankBranchID { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(50)]
        public string IBAN { get; set; }

        [StringLength(16)]
        public string AccountNo { get; set; }

        public virtual Bank Bank { get; set; }

        public virtual BankBranch BankBranch { get; set; }

        public virtual Company Company { get; set; }
    }
}
