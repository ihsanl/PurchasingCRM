namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("MessageOffer")]
    public partial class MessageOffer:BaseEntity
    {
        public MessageOffer()
        {
            MessageRequest = new HashSet<MessageRequest>();
        }

        public int ID { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        public string Description { get; set; }

        public virtual ICollection<MessageRequest> MessageRequest { get; set; }
    }
}
