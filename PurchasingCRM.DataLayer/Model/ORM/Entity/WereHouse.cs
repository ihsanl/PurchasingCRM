namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("WereHouse")]
    public partial class WereHouse:BaseEntity
    {
       public WereHouse()
        {
            Stock = new HashSet<Stock>();
            WereHouseTransfer = new HashSet<WereHouseTransfer>();
            WereHouseTransfer1 = new HashSet<WereHouseTransfer>();
        }

        
        public byte ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public decimal? Capacity { get; set; }

        public virtual ICollection<Stock> Stock { get; set; }

        public virtual ICollection<WereHouseTransfer> WereHouseTransfer { get; set; }

        public virtual ICollection<WereHouseTransfer> WereHouseTransfer1 { get; set; }
    }
}
