namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Department")]
    public partial class Department:BaseEntity
    {
        public Department()
        {
            DepartmentBudget = new HashSet<DepartmentBudget>();
            UserDetail = new HashSet<UserDetail>();
        }

      
        public byte ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

         public virtual ICollection<DepartmentBudget> DepartmentBudget { get; set; }

         public virtual ICollection<UserDetail> UserDetail { get; set; }
    }
}
