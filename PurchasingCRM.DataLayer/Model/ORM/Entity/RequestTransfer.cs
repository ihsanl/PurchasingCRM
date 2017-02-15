namespace PurchasingCRM.Data.Model.ORM.Entity
{
    
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("RequestTransfer")]
    public partial class RequestTransfer:BaseEntity
    {
        public int ID { get; set; }

        public int RequestProductOfferID { get; set; }

        public decimal? Quantity { get; set; }

        public string Description { get; set; }


        public virtual RequestProductOffer RequestProductOffer { get; set; }
    }
}
