namespace PurchasingCRM.Data.Model.ORM.Entity
{
    
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("RequestState")]
    public partial class RequestState:BaseEntity
    {
        public RequestState()
        {
            Request = new HashSet<Request>();
        }

        public byte ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Name { get; set; }

        public virtual ICollection<Request> Request { get; set; }
    }
}
