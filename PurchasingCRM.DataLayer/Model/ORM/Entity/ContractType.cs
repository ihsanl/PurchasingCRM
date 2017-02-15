namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ContractType")]
    public partial class ContractType:BaseEntity
    {
        public ContractType()
        {
            Contract = new HashSet<Contract>();
        }

      
        public byte ID { get; set; }

        [StringLength(10)]
        public string Name { get; set; }

       public virtual ICollection<Contract> Contract { get; set; }
    }
}
