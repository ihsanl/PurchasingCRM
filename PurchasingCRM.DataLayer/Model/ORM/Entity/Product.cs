namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Product")]
    public partial class Product:BaseEntity
    {
        public Product()
        {
            OpportunityProduct = new HashSet<OpportunityProduct>();
            WereHouseTransfer = new HashSet<WereHouseTransfer>();
        }

        public int ID { get; set; }

        public int CategoryID { get; set; }

        public int? StockID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        public bool? Status { get; set; }

        public byte? BrandID { get; set; }

        public byte? ProductTypeID { get; set; }

        public byte? VatID { get; set; }

        public float? Price { get; set; }

        [StringLength(20)]
        public string ManufacturerCode { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public byte? ProductUnitID { get; set; }


        public virtual Brand Brand { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<OpportunityProduct> OpportunityProduct { get; set; }

        public virtual Vat Vat { get; set; }

        public virtual ProductType ProductType { get; set; }

        public virtual ProductUnit ProductUnit { get; set; }

        public virtual Stock Stock { get; set; }

        public virtual ICollection<WereHouseTransfer> WereHouseTransfer { get; set; }
    }
}
