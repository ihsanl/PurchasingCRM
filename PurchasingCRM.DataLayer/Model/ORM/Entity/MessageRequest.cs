namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("MessageRequest")]
    public partial class MessageRequest:BaseEntity
    {
        public int ID { get; set; }

        public int? MessageOfferID { get; set; }

        public int? RequestProductID { get; set; }

        public virtual MessageOffer MessageOffer { get; set; }

        public virtual RequestProduct RequestProduct { get; set; }
    }
}
