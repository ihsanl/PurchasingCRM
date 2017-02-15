namespace PurchasingCRM.Data.Model.ORM.Entity
{
   
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("OfferText")]
    public partial class OfferText:BaseEntity
    {
        public int ID { get; set; }

        public int? RequestProductOfferID { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        public string Text { get; set; }

        public virtual RequestProductOffer RequestProductOffer { get; set; }
    }
}
