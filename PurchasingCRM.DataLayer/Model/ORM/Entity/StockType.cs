namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("StockType")]
    public partial class StockType:BaseEntity
    {
         public StockType()
        {
            Stock = new HashSet<Stock>();
        }
    
        public byte ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

         public virtual ICollection<Stock> Stock { get; set; }
    }
}
