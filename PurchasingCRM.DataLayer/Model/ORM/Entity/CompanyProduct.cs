namespace PurchasingCRM.Data.Model.ORM.Entity
{
   
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CompanyProduct")]
    public partial class CompanyProduct:BaseEntity
    {
        public int ID { get; set; }

        public int CompanyID { get; set; }

        public int ProductID { get; set; }

        public decimal? TotalNumber { get; set; }

        [StringLength(10)]
        public string SeriNo { get; set; }

        [StringLength(50)]
        public string Description { get; set; }


        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public virtual Company Company { get; set; }
    }
}
