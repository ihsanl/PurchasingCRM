namespace PurchasingCRM.Data.Model.ORM.Entity
{
   
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Stock")]
    public partial class Stock:BaseEntity
    {
        public Stock()
        {
            Product = new HashSet<Product>();
        }

        public int ID { get; set; }

        public byte StockTypeID { get; set; }

        public int CompanyID { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }

        public decimal? Quantity { get; set; }

        public string Description { get; set; }

        public decimal? Critical { get; set; }

        public byte? WereHouseID { get; set; }

        public virtual Company Company { get; set; }
       public virtual ICollection<Product> Product { get; set; }

        public virtual StockType StockType { get; set; }

        public virtual WereHouse WereHouse { get; set; }
    }
}
