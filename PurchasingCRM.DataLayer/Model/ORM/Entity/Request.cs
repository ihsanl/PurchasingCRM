namespace PurchasingCRM.Data.Model.ORM.Entity
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Request")]
    public partial class Request:BaseEntity
    {
        public Request()
        {
            RequestProduct = new HashSet<RequestProduct>();
        }

        public int ID { get; set; }

        public byte RequestStateID { get; set; }

        public int UserID { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public string WhyNeed { get; set; }


        public virtual RequestState RequestState { get; set; }

        public virtual UserDetail UserDetail { get; set; }

        public virtual ICollection<RequestProduct> RequestProduct { get; set; }
    }
}
