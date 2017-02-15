namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ContractFile")]
    public partial class ContractFile:BaseEntity
    {
        public int ID { get; set; }

        public int? ContractID { get; set; }

        [StringLength(500)]
        public string FileName { get; set; }

        public string FilePath { get; set; }

        public virtual Contract Contract { get; set; }
    }
}
