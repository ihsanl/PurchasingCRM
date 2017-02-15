namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("WereHouseTransfer")]
    public partial class WereHouseTransfer:BaseEntity
    {
        public int ID { get; set; }

        public byte? SetStoreID { get; set; }

        public byte? GetStoreID { get; set; }

        public int? ProductID { get; set; }

        public decimal? Quantity { get; set; }

        public DateTime? ProcessDate { get; set; }

        public virtual Product Product { get; set; }

        public virtual WereHouse WereHouse { get; set; }

        public virtual WereHouse WereHouse1 { get; set; }
    }
}
