namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DepartmentBudget")]
    public partial class DepartmentBudget:BaseEntity
    {
        public int ID { get; set; }

        public byte DepartmentID { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalBudget { get; set; }

        public virtual Department Department { get; set; }
    }
}
