namespace PurchasingCRM.Data.Model.ORM.Entity
{

    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ContractProduct")]
    public partial class ContractProduct:BaseEntity
    {
        public int ID { get; set; }

        public int? ContractID { get; set; }

        public int? RequestProductOfferID { get; set; }

        public virtual Contract Contract { get; set; }

        public virtual RequestProductOffer RequestProductOffer { get; set; }
    }
}
