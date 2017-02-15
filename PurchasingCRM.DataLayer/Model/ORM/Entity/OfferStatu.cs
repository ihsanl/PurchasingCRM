namespace PurchasingCRM.Data.Model.ORM.Entity
{
    
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("OfferStatu")]
    public partial class OfferStatu:BaseEntity
    {
       public OfferStatu()
        {
            RequestProductOffer = new HashSet<RequestProductOffer>();
        }

      
        public byte ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<RequestProductOffer> RequestProductOffer { get; set; }
    }
}
