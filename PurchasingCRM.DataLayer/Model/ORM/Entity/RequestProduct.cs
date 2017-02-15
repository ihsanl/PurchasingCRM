namespace PurchasingCRM.Data.Model.ORM.Entity
{
    
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("RequestProduct")]
    public partial class RequestProduct:BaseEntity
    {
        public RequestProduct()
        {
            MessageRequest = new HashSet<MessageRequest>();
            RequestProductOffer = new HashSet<RequestProductOffer>();
        }

        public int ID { get; set; }

        public int RequestID { get; set; }

        public int? ProductID { get; set; }

        [StringLength(50)]
        public string ProductCode { get; set; }

        public bool? Status { get; set; }

        public bool? UpperAuthorityStatus { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        public decimal? Quantity { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public byte? ProductUnitID { get; set; }

        public virtual ICollection<MessageRequest> MessageRequest { get; set; }

        public virtual ProductUnit ProductUnit { get; set; }

        public virtual Request Request { get; set; }

         public virtual ICollection<RequestProductOffer> RequestProductOffer { get; set; }
    }
}
